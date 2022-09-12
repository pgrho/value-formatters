using System.IO;

namespace Shipwreck.ValueFormatters.Composition;

internal static class CharLiteralSpecifier
{
    public static void WriteToCore<T, TValue>(this T specifier, TextWriter writer, TValue value)
        where T : ICharLiteralSpecifier<TValue>
        => writer.Write(specifier.Char);

    public static bool TryFormatCore<T, TValue>(this T specifier, Span<char> destination, out int charsWritten, TValue value)
        where T : ICharLiteralSpecifier<TValue>
    {
        if (destination.Length > 0)
        {
            charsWritten = 1;
            destination[0] = specifier.Char;
            return true;
        }
        charsWritten = 0;
        return false;
    }
}
