using System.IO;

namespace Shipwreck.ValueFormatters;

public abstract class Int32ValueFormatter : IValueFormatter<sbyte>, IValueFormatter<byte>, IValueFormatter<short>, IValueFormatter<ushort>, IValueFormatter<int>, IValueFormatter<uint>, IValueFormatter<long>, IValueFormatter<ulong>
{
    #region Supports

    public abstract bool Supports(int value, ReadOnlySpan<char> format, IFormatProvider provider);

    public bool Supports(sbyte value, ReadOnlySpan<char> format, IFormatProvider provider)
        => Supports((int)value, format, provider);

    public bool Supports(byte value, ReadOnlySpan<char> format, IFormatProvider provider)
        => Supports((int)value, format, provider);

    public bool Supports(short value, ReadOnlySpan<char> format, IFormatProvider provider)
        => Supports((int)value, format, provider);

    public bool Supports(ushort value, ReadOnlySpan<char> format, IFormatProvider provider)
        => Supports((int)value, format, provider);

    public bool Supports(uint value, ReadOnlySpan<char> format, IFormatProvider provider)
        => value <= int.MaxValue && Supports((int)value, format, provider);

    public bool Supports(long value, ReadOnlySpan<char> format, IFormatProvider provider)
        => int.MinValue <= value && value <= int.MaxValue && Supports((int)value, format, provider);

    public bool Supports(ulong value, ReadOnlySpan<char> format, IFormatProvider provider)
        => value <= int.MaxValue && Supports((int)value, format, provider);

    #endregion Supports

    #region WriteTo

    public abstract void WriteTo(TextWriter writer, int value, ReadOnlySpan<char> format, IFormatProvider provider);

    public void WriteTo(TextWriter writer, sbyte value, ReadOnlySpan<char> format, IFormatProvider provider)
        => WriteTo(writer, (int)value, format, provider);

    public void WriteTo(TextWriter writer, byte value, ReadOnlySpan<char> format, IFormatProvider provider)
        => WriteTo(writer, (int)value, format, provider);

    public void WriteTo(TextWriter writer, short value, ReadOnlySpan<char> format, IFormatProvider provider)
        => WriteTo(writer, (int)value, format, provider);

    public void WriteTo(TextWriter writer, ushort value, ReadOnlySpan<char> format, IFormatProvider provider)
        => WriteTo(writer, (int)value, format, provider);

    public void WriteTo(TextWriter writer, uint value, ReadOnlySpan<char> format, IFormatProvider provider)
        => WriteTo(writer, checked((int)value), format, provider);

    public void WriteTo(TextWriter writer, long value, ReadOnlySpan<char> format, IFormatProvider provider)
        => WriteTo(writer, checked((int)value), format, provider);

    public void WriteTo(TextWriter writer, ulong value, ReadOnlySpan<char> format, IFormatProvider provider)
        => WriteTo(writer, checked((int)value), format, provider);

    #endregion WriteTo

    #region TryFormat

    public virtual bool TryFormat(Span<char> destination, out int charsWritten, int value, ReadOnlySpan<char> format, IFormatProvider provider)
    {
        if (Supports(value, format, provider))
        {
            using (var sw = new StringWriter())
            {
                WriteTo(sw, value, format, provider);
                var b = sw.GetStringBuilder();
                charsWritten = b.Length;
                for (var i = 0; i < b.Length; i++)
                {
                    destination[i] = b[i];
                }
                return true;
            }
        }
        charsWritten = 0;
        return false;
    }

    public bool TryFormat(Span<char> destination, out int charsWritten, sbyte value, ReadOnlySpan<char> format, IFormatProvider provider)
        => TryFormat(destination, out charsWritten, (int)value, format, provider);

    public bool TryFormat(Span<char> destination, out int charsWritten, byte value, ReadOnlySpan<char> format, IFormatProvider provider)
        => TryFormat(destination, out charsWritten, (int)value, format, provider);

    public bool TryFormat(Span<char> destination, out int charsWritten, short value, ReadOnlySpan<char> format, IFormatProvider provider)
        => TryFormat(destination, out charsWritten, (int)value, format, provider);

    public bool TryFormat(Span<char> destination, out int charsWritten, ushort value, ReadOnlySpan<char> format, IFormatProvider provider)
        => TryFormat(destination, out charsWritten, (int)value, format, provider);

    public bool TryFormat(Span<char> destination, out int charsWritten, uint value, ReadOnlySpan<char> format, IFormatProvider provider)
        => TryFormat(destination, out charsWritten, checked((int)value), format, provider);

    public bool TryFormat(Span<char> destination, out int charsWritten, long value, ReadOnlySpan<char> format, IFormatProvider provider)
        => TryFormat(destination, out charsWritten, checked((int)value), format, provider);

    public bool TryFormat(Span<char> destination, out int charsWritten, ulong value, ReadOnlySpan<char> format, IFormatProvider provider)
        => TryFormat(destination, out charsWritten, checked((int)value), format, provider);

    #endregion TryFormat
}
