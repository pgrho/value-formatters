using System.IO;

namespace Shipwreck.ValueFormatters.Composition;

internal struct TicksSpecifier<TLength, TDot, TTrim>
    where TLength : IInteger
    where TDot : IBoolean
    where TTrim : IBoolean
{
    public int Length => default(TLength)?.Value ?? 0;
    public bool HasDot => default(TDot)?.Value ?? false;
    public bool ShouldTrim => default(TTrim)?.Value ?? false;

    public void WriteTo(TextWriter writer, DateTime value, IFormatProvider formatProvider)
        => WriteToCore(writer, value);

    public void WriteTo(TextWriter writer, DateTimeOffset value, IFormatProvider formatProvider)
        => WriteToCore(writer, value.DateTime);

    public bool TryFormat(Span<char> destination, out int charsWritten, DateTime value, IFormatProvider formatProvider)
        => TryFormatCore(destination, out charsWritten, value);

    public bool TryFormat(Span<char> destination, out int charsWritten, DateTimeOffset value, IFormatProvider formatProvider)
        => TryFormatCore(destination, out charsWritten, value.DateTime);

    unsafe private void WriteToCore(TextWriter writer, DateTime value)
    {
        GetDigits(value, out var length, out var bcd);

        if (length > 0)
        {
            byte* fs = ((byte*)&bcd) + 1;
            if (HasDot)
            {
                writer.Write('.');
            }

            for (var i = 0; i < length; i++)
            {
                writer.Write((char)(fs[i] + '0'));
            }
        }
    }

    unsafe bool TryFormatCore(Span<char> destination, out int charsWritten, DateTime value)
    {
        GetDigits(value, out var length, out var bcd);

        if (length == 0)
        {
            charsWritten = 0;
            return true;
        }

        if (destination.Length < (HasDot ? 1 : 0) + length)
        {
            charsWritten = 0;
            return false;
        }

        charsWritten = 0;
        byte* fs = ((byte*)&bcd) + 1;
        if (HasDot)
        {
            destination[charsWritten++] = ('.');
        }

        for (var i = 0; i < length; i++)
        {
            destination[charsWritten++] = ((char)(fs[i] + '0'));
        }

        return true;
    }

    private unsafe void GetDigits(DateTime value, out int length, out long bcd)
    {
        length = Length;

        var res = ((int)(value.TimeOfDay.Ticks % TimeSpan.TicksPerSecond)).ToBcdInt64();

        byte* fs = ((byte*)&res) + 1;

        if (length < 7)
        {
            if (fs[length] >= 5)
            {
                fs[length - 1]++;
            }

            for (var i = length - 1; i >= 0; i--)
            {
                if (fs[i] == 10)
                {
                    fs[i] = 0;
                    if (i > 0)
                    {
                        fs[i - 1]++;
                    }
                }
                else
                {
                    break;
                }
            }
        }

        if (ShouldTrim)
        {
            for (var i = length - 1; i >= 0; i--)
            {
                if (fs[i] != 0)
                {
                    break;
                }
                length--;
            }
        }

        bcd = res;
    }
}
