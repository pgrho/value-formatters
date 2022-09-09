using System.IO;

namespace Shipwreck.ValueFormatters.Composition;

internal static class DateTimeArraySpecifier
{
    public static void WriteToCore<T>(this T specifier, TextWriter writer, DateTimeOffset value, IFormatProvider formatProvider)
        where T : IDateTimeArraySpecifier
        => WriteToCore(specifier, writer, value.DateTime, formatProvider);

    public static void WriteToCore<T>(this T specifier, TextWriter writer, DateTime value, IFormatProvider formatProvider)
        where T : IDateTimeArraySpecifier
    {
        var dtf = (DateTimeFormatInfo)(formatProvider ?? CultureInfo.InvariantCulture).GetFormat(typeof(DateTimeFormatInfo));
        writer.Write(specifier.GetArray(dtf)[specifier.GetIndex(value)]);
    }

    public static bool TryFormatCore<T>(this T specifier, Span<char> destination, out int charsWritten, DateTimeOffset value, IFormatProvider formatProvider)
        where T : IDateTimeArraySpecifier
        => TryFormatCore(specifier, destination, out charsWritten, value.DateTime, formatProvider);

    public static bool TryFormatCore<T>(this T specifier, Span<char> destination, out int charsWritten, DateTime value, IFormatProvider formatProvider)
        where T : IDateTimeArraySpecifier
    {
        var dtf = (DateTimeFormatInfo)(formatProvider ?? CultureInfo.InvariantCulture).GetFormat(typeof(DateTimeFormatInfo));
        var s = specifier.GetArray(dtf)[specifier.GetIndex(value)];
        if (destination.Length < s.Length)
        {
            charsWritten = 0;
            return false;
        }

        for (var i = 0; i < s.Length; i++)
        {
            destination[i] = s[i];
        }
        charsWritten = s.Length;

        return true;
    }
}
