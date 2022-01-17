using System.IO;

namespace Shipwreck.ValueFormatters;

public static class ValueFormatterExtensions
{
    public static string ToString<T>(this IValueFormatter<T> formatter, T value, string format, IFormatProvider formatProvider = null)
    {
        using (var sw = new StringWriter())
        {
            formatter.WriteTo(sw, value, format, formatProvider ?? CultureInfo.CurrentCulture);
            return sw.ToString();
        }
    }

    public static StringBuilder AppendTo<T>(this IValueFormatter<T> formatter, StringBuilder stringBuilder, T value, string format, IFormatProvider formatProvider = null)
    {
        using (var sw = new StringWriter(stringBuilder))
        {
            formatter.WriteTo(sw, value, format, formatProvider ?? CultureInfo.CurrentCulture);
            return stringBuilder;
        }
    }
}
