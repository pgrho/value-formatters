using System.IO;

namespace Shipwreck.ValueFormatters;

public interface IValueFormatter<T>
{
    bool Supports(T value, ReadOnlySpan<char> format, IFormatProvider provider);

    void WriteTo(TextWriter writer, T value, ReadOnlySpan<char> format, IFormatProvider provider);
    bool TryFormat(Span<char> destination, out int charsWritten, T value, ReadOnlySpan<char> format, IFormatProvider provider);
}
