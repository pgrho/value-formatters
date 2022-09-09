using System.IO;

namespace Shipwreck.ValueFormatters.Composition;

internal static class DateTimeDigitSpecifier
{
    public static void WriteToCore<T>(this T specifier, TextWriter writer, DateTimeOffset value)
        where T : IDateTimeDigitSpecifier
        => WriteToCore(specifier, writer, value.DateTime);

    public static void WriteToCore<T>(this T specifier, TextWriter writer, DateTime value)
        where T : IDateTimeDigitSpecifier
    {
        var d = specifier.GetNumber(value);
        var ml = specifier.MinimumLength;

        if (d >= 0)
        {
            if (d < 10000 && ml >= 5)
            {
                writer.Write('0');
            }
            if (d < 1000 && ml >= 4)
            {
                writer.Write('0');
            }
            if (d < 100 && ml >= 3)
            {
                writer.Write('0');
            }
            if (d < 10 && ml >= 2)
            {
                writer.Write('0');
            }
        }

        writer.Write(d);
    }

    public static bool TryFormatCore<T>(this T specifier, Span<char> destination, out int charsWritten, DateTimeOffset value)
        where T : IDateTimeDigitSpecifier
        => TryFormatCore(specifier, destination, out charsWritten, value.DateTime);

    public static bool TryFormatCore<T>(this T specifier, Span<char> destination, out int charsWritten, DateTime value)
        where T : IDateTimeDigitSpecifier
    {
        var d = specifier.GetNumber(value);
        var min = specifier.MinimumLength;

        int d0, d1, d2, d3, d4;
        d = Math.DivRem(d, 10, out d4);
        d = Math.DivRem(d, 10, out d3);
        d = Math.DivRem(d, 10, out d2);
        d0 = Math.DivRem(d, 10, out d1);

        var l = Math.Max(d0 > 0 ? 5 : d1 > 0 ? 4 : d2 > 0 ? 3 : d3 > 0 ? 2 : 1, min);

        if (destination.Length < l)
        {
            charsWritten = 0;
            return false;
        }

        var i = 0;
        if (l >= 5)
        {
            destination[i++] = (char)(d0 - '0');
        }
        if (l >= 4)
        {
            destination[i++] = (char)(d1 - '0');
        }
        if (l >= 3)
        {
            destination[i++] = (char)(d2 - '0');
        }
        if (l >= 2)
        {
            destination[i++] = (char)(d3 - '0');
        }

        destination[i++] = (char)(d4 - '0');

        charsWritten = i;

        return true;
    }
}
