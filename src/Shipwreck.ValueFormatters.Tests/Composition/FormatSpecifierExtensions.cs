using System.IO;

namespace Shipwreck.ValueFormatters.Composition;

internal static class FormatSpecifierExtensions
{
    public static string Format<T>(this T specifier, DateTime value, IFormatProvider? formatProvider = null)
        where T : IFormatSpecifier<DateTime>
    {
        var sw = new StringWriter();
        specifier.WriteTo(sw, value, formatProvider);

        return sw.ToString();
    }
}
