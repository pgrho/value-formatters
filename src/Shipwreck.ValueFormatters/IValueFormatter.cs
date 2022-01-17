using System.IO;

namespace Shipwreck.ValueFormatters;

public interface IValueFormatter<T>
{
    bool Supports(T value, string format, IFormatProvider formatProvider);

    void WriteTo(TextWriter writer, T value, string format, IFormatProvider formatProvider);
}
