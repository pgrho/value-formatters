using System.IO;

namespace Shipwreck.ValueFormatters;

public static class ValueFormatterExtensions
{
    public static string ToString<T>(this IValueFormatter<T> formatter, T value, string format, IFormatProvider provider = null)
        => formatter.ToString(value, format.AsSpan(), provider);

    public static string ToString<T>(this IValueFormatter<T> formatter, T value, ReadOnlySpan<char> format, IFormatProvider provider = null)
    {
        using (var sw = new StringWriter())
        {
            formatter.WriteTo(sw, value, format, provider ?? CultureInfo.CurrentCulture);
            return sw.ToString();
        }
    }

    public static StringBuilder AppendTo<T>(this IValueFormatter<T> formatter, StringBuilder stringBuilder, T value, string format, IFormatProvider provider = null)
        => formatter.AppendTo(stringBuilder, value, format.AsSpan(), provider);

    public static StringBuilder AppendTo<T>(this IValueFormatter<T> formatter, StringBuilder stringBuilder, T value, ReadOnlySpan<char> format, IFormatProvider provider = null)
    {
        using (var sw = new StringWriter(stringBuilder))
        {
            formatter.WriteTo(sw, value, format, provider ?? CultureInfo.CurrentCulture);
            return stringBuilder;
        }
    }

    public static void WriteTo<T>(this IValueFormatter<T> formatter, TextWriter writer, T value, string format, IFormatProvider provider = null)
        => formatter.WriteTo(writer, value, format.AsSpan(), provider);
}
