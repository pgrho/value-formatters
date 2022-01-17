using System.IO;

namespace Shipwreck.ValueFormatters;

public abstract class Int32ValueFormatter : IValueFormatter<sbyte>, IValueFormatter<byte>, IValueFormatter<short>, IValueFormatter<ushort>, IValueFormatter<int>, IValueFormatter<uint>, IValueFormatter<long>, IValueFormatter<ulong>
{
    #region Supports

    public abstract bool Supports(int value, string format, IFormatProvider formatProvider);

    public bool Supports(sbyte value, string format, IFormatProvider formatProvider)
        => Supports((int)value, format, formatProvider);

    public bool Supports(byte value, string format, IFormatProvider formatProvider)
        => Supports((int)value, format, formatProvider);

    public bool Supports(short value, string format, IFormatProvider formatProvider)
        => Supports((int)value, format, formatProvider);

    public bool Supports(ushort value, string format, IFormatProvider formatProvider)
        => Supports((int)value, format, formatProvider);

    public bool Supports(uint value, string format, IFormatProvider formatProvider)
        => value <= int.MaxValue && Supports((int)value, format, formatProvider);

    public bool Supports(long value, string format, IFormatProvider formatProvider)
        => int.MinValue <= value && value <= int.MaxValue && Supports((int)value, format, formatProvider);

    public bool Supports(ulong value, string format, IFormatProvider formatProvider)
        => value <= int.MaxValue && Supports((int)value, format, formatProvider);

    #endregion Supports

    #region WriteTo

    public abstract void WriteTo(TextWriter writer, int value, string format, IFormatProvider formatProvider);

    public void WriteTo(TextWriter writer, sbyte value, string format, IFormatProvider formatProvider)
        => WriteTo(writer, (int)value, format, formatProvider);

    public void WriteTo(TextWriter writer, byte value, string format, IFormatProvider formatProvider)
        => WriteTo(writer, (int)value, format, formatProvider);

    public void WriteTo(TextWriter writer, short value, string format, IFormatProvider formatProvider)
        => WriteTo(writer, (int)value, format, formatProvider);

    public void WriteTo(TextWriter writer, ushort value, string format, IFormatProvider formatProvider)
        => WriteTo(writer, (int)value, format, formatProvider);

    public void WriteTo(TextWriter writer, uint value, string format, IFormatProvider formatProvider)
        => WriteTo(writer, checked((int)value), format, formatProvider);

    public void WriteTo(TextWriter writer, long value, string format, IFormatProvider formatProvider)
        => WriteTo(writer, checked((int)value), format, formatProvider);

    public void WriteTo(TextWriter writer, ulong value, string format, IFormatProvider formatProvider)
        => WriteTo(writer, checked((int)value), format, formatProvider);

    #endregion WriteTo
}
