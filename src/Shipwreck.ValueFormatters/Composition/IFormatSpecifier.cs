using System.IO;

namespace Shipwreck.ValueFormatters.Composition;

public interface IFormatSpecifier<T>
{
    void WriteTo(TextWriter writer, T value, IFormatProvider formatProvider);

    bool TryFormat(Span<char> destination, out int charsWritten, T value, IFormatProvider formatProvider);
}
