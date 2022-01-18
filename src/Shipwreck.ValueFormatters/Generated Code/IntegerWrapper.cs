namespace Shipwreck.ValueFormatters;
public partial struct SByteWrapper : IEquatable<SByteWrapper>, IComparable, IComparable<SByteWrapper>, IConvertible, IFormattable
#if NET6_0_OR_GREATER
    , ISpanFormattable
#endif
{
	public SByteWrapper(SByte value)
		=> Value = value;
        
    public static SByteWrapper MinValue => SByte.MinValue;
    public static SByteWrapper MaxValue => SByte.MaxValue;

	public SByte Value { get; }

    public static implicit operator SByte(SByteWrapper value)
        => value.Value;

    public static implicit operator SByteWrapper(SByte value)
        => new(value);

    public static bool operator ==(SByteWrapper left, SByteWrapper right)
        => left.Value == right.Value;

    public static bool operator !=(SByteWrapper left, SByteWrapper right)
        => left.Value != right.Value;

    public override bool Equals(object obj)
        => obj is SByteWrapper other && Equals(other);

    public bool Equals(SByteWrapper other)
        => this == other;

    public override int GetHashCode()
        => Value.GetHashCode();
    
    int IComparable.CompareTo(object obj)
        => Value.CompareTo(((SByteWrapper)obj).Value);

    public int CompareTo(SByteWrapper other)
        => Value.CompareTo(other.Value);

    public override string ToString()
        => Value.ToString();
        
    public string ToString(IFormatProvider provider)
        => Value.ToString(provider);
    
    public string ToString(string format)
        => ToString(format, CultureInfo.CurrentCulture);

    public string ToString(string format, IFormatProvider provider)
    {
        if (format?.Length > 0)
        {
            var fs = format.AsSpan();

            var rnf = new RomanNumeralFormatter();
            if (rnf.Supports(1, fs, provider))
            {
                if (rnf.Supports(Value, fs, provider))
                {
                    return rnf.ToString(Value, fs, provider);
                }
                return Value.ToString("D", provider);
            }
        }
        return Value.ToString(format, provider);
    }

    #region IConvertible

    TypeCode IConvertible.GetTypeCode() => Value.GetTypeCode();

    object IConvertible.ToType(Type conversionType, IFormatProvider provider)
    {
        return ((IConvertible)Value).ToType(conversionType, provider);
    }

    decimal IConvertible.ToDecimal(IFormatProvider provider)
        => Value;

    double IConvertible.ToDouble(IFormatProvider provider)
        => Value;

    float IConvertible.ToSingle(IFormatProvider provider)
        => Value;

    bool IConvertible.ToBoolean(IFormatProvider provider)
        => ((IConvertible)Value).ToBoolean(provider);

    char IConvertible.ToChar(IFormatProvider provider) => ((IConvertible)Value).ToChar(provider);

    DateTime IConvertible.ToDateTime(IFormatProvider provider) => ((IConvertible)Value).ToDateTime(provider);

    SByte IConvertible.ToSByte(IFormatProvider provider)
        => checked((SByte)Value);
    Byte IConvertible.ToByte(IFormatProvider provider)
        => checked((Byte)Value);
    Int16 IConvertible.ToInt16(IFormatProvider provider)
        => checked((Int16)Value);
    UInt16 IConvertible.ToUInt16(IFormatProvider provider)
        => checked((UInt16)Value);
    Int32 IConvertible.ToInt32(IFormatProvider provider)
        => checked((Int32)Value);
    UInt32 IConvertible.ToUInt32(IFormatProvider provider)
        => checked((UInt32)Value);
    Int64 IConvertible.ToInt64(IFormatProvider provider)
        => checked((Int64)Value);
    UInt64 IConvertible.ToUInt64(IFormatProvider provider)
        => checked((UInt64)Value);

    #endregion IConvertible
#if NET6_0_OR_GREATER
    public bool TryFormat (Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider)
    {
        if (format.Length > 0)
        {
            var rnf = new RomanNumeralFormatter();
            if (rnf.Supports(1, format, provider))
            {
                if (rnf.Supports(Value, format, provider))
                {
                    rnf.TryFormat(destination,out charsWritten, Value, format, provider);
                    return true;
                }
                return Value.TryFormat(destination, out charsWritten, "D".AsSpan(), provider);
            }
        }
        return Value.TryFormat(destination, out charsWritten, format, provider);
    }
#endif
}
public partial struct ByteWrapper : IEquatable<ByteWrapper>, IComparable, IComparable<ByteWrapper>, IConvertible, IFormattable
#if NET6_0_OR_GREATER
    , ISpanFormattable
#endif
{
	public ByteWrapper(Byte value)
		=> Value = value;
        
    public static ByteWrapper MinValue => Byte.MinValue;
    public static ByteWrapper MaxValue => Byte.MaxValue;

	public Byte Value { get; }

    public static implicit operator Byte(ByteWrapper value)
        => value.Value;

    public static implicit operator ByteWrapper(Byte value)
        => new(value);

    public static bool operator ==(ByteWrapper left, ByteWrapper right)
        => left.Value == right.Value;

    public static bool operator !=(ByteWrapper left, ByteWrapper right)
        => left.Value != right.Value;

    public override bool Equals(object obj)
        => obj is ByteWrapper other && Equals(other);

    public bool Equals(ByteWrapper other)
        => this == other;

    public override int GetHashCode()
        => Value.GetHashCode();
    
    int IComparable.CompareTo(object obj)
        => Value.CompareTo(((ByteWrapper)obj).Value);

    public int CompareTo(ByteWrapper other)
        => Value.CompareTo(other.Value);

    public override string ToString()
        => Value.ToString();
        
    public string ToString(IFormatProvider provider)
        => Value.ToString(provider);
    
    public string ToString(string format)
        => ToString(format, CultureInfo.CurrentCulture);

    public string ToString(string format, IFormatProvider provider)
    {
        if (format?.Length > 0)
        {
            var fs = format.AsSpan();

            var rnf = new RomanNumeralFormatter();
            if (rnf.Supports(1, fs, provider))
            {
                if (rnf.Supports(Value, fs, provider))
                {
                    return rnf.ToString(Value, fs, provider);
                }
                return Value.ToString("D", provider);
            }
        }
        return Value.ToString(format, provider);
    }

    #region IConvertible

    TypeCode IConvertible.GetTypeCode() => Value.GetTypeCode();

    object IConvertible.ToType(Type conversionType, IFormatProvider provider)
    {
        return ((IConvertible)Value).ToType(conversionType, provider);
    }

    decimal IConvertible.ToDecimal(IFormatProvider provider)
        => Value;

    double IConvertible.ToDouble(IFormatProvider provider)
        => Value;

    float IConvertible.ToSingle(IFormatProvider provider)
        => Value;

    bool IConvertible.ToBoolean(IFormatProvider provider)
        => ((IConvertible)Value).ToBoolean(provider);

    char IConvertible.ToChar(IFormatProvider provider) => ((IConvertible)Value).ToChar(provider);

    DateTime IConvertible.ToDateTime(IFormatProvider provider) => ((IConvertible)Value).ToDateTime(provider);

    SByte IConvertible.ToSByte(IFormatProvider provider)
        => checked((SByte)Value);
    Byte IConvertible.ToByte(IFormatProvider provider)
        => checked((Byte)Value);
    Int16 IConvertible.ToInt16(IFormatProvider provider)
        => checked((Int16)Value);
    UInt16 IConvertible.ToUInt16(IFormatProvider provider)
        => checked((UInt16)Value);
    Int32 IConvertible.ToInt32(IFormatProvider provider)
        => checked((Int32)Value);
    UInt32 IConvertible.ToUInt32(IFormatProvider provider)
        => checked((UInt32)Value);
    Int64 IConvertible.ToInt64(IFormatProvider provider)
        => checked((Int64)Value);
    UInt64 IConvertible.ToUInt64(IFormatProvider provider)
        => checked((UInt64)Value);

    #endregion IConvertible
#if NET6_0_OR_GREATER
    public bool TryFormat (Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider)
    {
        if (format.Length > 0)
        {
            var rnf = new RomanNumeralFormatter();
            if (rnf.Supports(1, format, provider))
            {
                if (rnf.Supports(Value, format, provider))
                {
                    rnf.TryFormat(destination,out charsWritten, Value, format, provider);
                    return true;
                }
                return Value.TryFormat(destination, out charsWritten, "D".AsSpan(), provider);
            }
        }
        return Value.TryFormat(destination, out charsWritten, format, provider);
    }
#endif
}
public partial struct Int16Wrapper : IEquatable<Int16Wrapper>, IComparable, IComparable<Int16Wrapper>, IConvertible, IFormattable
#if NET6_0_OR_GREATER
    , ISpanFormattable
#endif
{
	public Int16Wrapper(Int16 value)
		=> Value = value;
        
    public static Int16Wrapper MinValue => Int16.MinValue;
    public static Int16Wrapper MaxValue => Int16.MaxValue;

	public Int16 Value { get; }

    public static implicit operator Int16(Int16Wrapper value)
        => value.Value;

    public static implicit operator Int16Wrapper(Int16 value)
        => new(value);

    public static bool operator ==(Int16Wrapper left, Int16Wrapper right)
        => left.Value == right.Value;

    public static bool operator !=(Int16Wrapper left, Int16Wrapper right)
        => left.Value != right.Value;

    public override bool Equals(object obj)
        => obj is Int16Wrapper other && Equals(other);

    public bool Equals(Int16Wrapper other)
        => this == other;

    public override int GetHashCode()
        => Value.GetHashCode();
    
    int IComparable.CompareTo(object obj)
        => Value.CompareTo(((Int16Wrapper)obj).Value);

    public int CompareTo(Int16Wrapper other)
        => Value.CompareTo(other.Value);

    public override string ToString()
        => Value.ToString();
        
    public string ToString(IFormatProvider provider)
        => Value.ToString(provider);
    
    public string ToString(string format)
        => ToString(format, CultureInfo.CurrentCulture);

    public string ToString(string format, IFormatProvider provider)
    {
        if (format?.Length > 0)
        {
            var fs = format.AsSpan();

            var rnf = new RomanNumeralFormatter();
            if (rnf.Supports(1, fs, provider))
            {
                if (rnf.Supports(Value, fs, provider))
                {
                    return rnf.ToString(Value, fs, provider);
                }
                return Value.ToString("D", provider);
            }
        }
        return Value.ToString(format, provider);
    }

    #region IConvertible

    TypeCode IConvertible.GetTypeCode() => Value.GetTypeCode();

    object IConvertible.ToType(Type conversionType, IFormatProvider provider)
    {
        return ((IConvertible)Value).ToType(conversionType, provider);
    }

    decimal IConvertible.ToDecimal(IFormatProvider provider)
        => Value;

    double IConvertible.ToDouble(IFormatProvider provider)
        => Value;

    float IConvertible.ToSingle(IFormatProvider provider)
        => Value;

    bool IConvertible.ToBoolean(IFormatProvider provider)
        => ((IConvertible)Value).ToBoolean(provider);

    char IConvertible.ToChar(IFormatProvider provider) => ((IConvertible)Value).ToChar(provider);

    DateTime IConvertible.ToDateTime(IFormatProvider provider) => ((IConvertible)Value).ToDateTime(provider);

    SByte IConvertible.ToSByte(IFormatProvider provider)
        => checked((SByte)Value);
    Byte IConvertible.ToByte(IFormatProvider provider)
        => checked((Byte)Value);
    Int16 IConvertible.ToInt16(IFormatProvider provider)
        => checked((Int16)Value);
    UInt16 IConvertible.ToUInt16(IFormatProvider provider)
        => checked((UInt16)Value);
    Int32 IConvertible.ToInt32(IFormatProvider provider)
        => checked((Int32)Value);
    UInt32 IConvertible.ToUInt32(IFormatProvider provider)
        => checked((UInt32)Value);
    Int64 IConvertible.ToInt64(IFormatProvider provider)
        => checked((Int64)Value);
    UInt64 IConvertible.ToUInt64(IFormatProvider provider)
        => checked((UInt64)Value);

    #endregion IConvertible
#if NET6_0_OR_GREATER
    public bool TryFormat (Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider)
    {
        if (format.Length > 0)
        {
            var rnf = new RomanNumeralFormatter();
            if (rnf.Supports(1, format, provider))
            {
                if (rnf.Supports(Value, format, provider))
                {
                    rnf.TryFormat(destination,out charsWritten, Value, format, provider);
                    return true;
                }
                return Value.TryFormat(destination, out charsWritten, "D".AsSpan(), provider);
            }
        }
        return Value.TryFormat(destination, out charsWritten, format, provider);
    }
#endif
}
public partial struct UInt16Wrapper : IEquatable<UInt16Wrapper>, IComparable, IComparable<UInt16Wrapper>, IConvertible, IFormattable
#if NET6_0_OR_GREATER
    , ISpanFormattable
#endif
{
	public UInt16Wrapper(UInt16 value)
		=> Value = value;
        
    public static UInt16Wrapper MinValue => UInt16.MinValue;
    public static UInt16Wrapper MaxValue => UInt16.MaxValue;

	public UInt16 Value { get; }

    public static implicit operator UInt16(UInt16Wrapper value)
        => value.Value;

    public static implicit operator UInt16Wrapper(UInt16 value)
        => new(value);

    public static bool operator ==(UInt16Wrapper left, UInt16Wrapper right)
        => left.Value == right.Value;

    public static bool operator !=(UInt16Wrapper left, UInt16Wrapper right)
        => left.Value != right.Value;

    public override bool Equals(object obj)
        => obj is UInt16Wrapper other && Equals(other);

    public bool Equals(UInt16Wrapper other)
        => this == other;

    public override int GetHashCode()
        => Value.GetHashCode();
    
    int IComparable.CompareTo(object obj)
        => Value.CompareTo(((UInt16Wrapper)obj).Value);

    public int CompareTo(UInt16Wrapper other)
        => Value.CompareTo(other.Value);

    public override string ToString()
        => Value.ToString();
        
    public string ToString(IFormatProvider provider)
        => Value.ToString(provider);
    
    public string ToString(string format)
        => ToString(format, CultureInfo.CurrentCulture);

    public string ToString(string format, IFormatProvider provider)
    {
        if (format?.Length > 0)
        {
            var fs = format.AsSpan();

            var rnf = new RomanNumeralFormatter();
            if (rnf.Supports(1, fs, provider))
            {
                if (rnf.Supports(Value, fs, provider))
                {
                    return rnf.ToString(Value, fs, provider);
                }
                return Value.ToString("D", provider);
            }
        }
        return Value.ToString(format, provider);
    }

    #region IConvertible

    TypeCode IConvertible.GetTypeCode() => Value.GetTypeCode();

    object IConvertible.ToType(Type conversionType, IFormatProvider provider)
    {
        return ((IConvertible)Value).ToType(conversionType, provider);
    }

    decimal IConvertible.ToDecimal(IFormatProvider provider)
        => Value;

    double IConvertible.ToDouble(IFormatProvider provider)
        => Value;

    float IConvertible.ToSingle(IFormatProvider provider)
        => Value;

    bool IConvertible.ToBoolean(IFormatProvider provider)
        => ((IConvertible)Value).ToBoolean(provider);

    char IConvertible.ToChar(IFormatProvider provider) => ((IConvertible)Value).ToChar(provider);

    DateTime IConvertible.ToDateTime(IFormatProvider provider) => ((IConvertible)Value).ToDateTime(provider);

    SByte IConvertible.ToSByte(IFormatProvider provider)
        => checked((SByte)Value);
    Byte IConvertible.ToByte(IFormatProvider provider)
        => checked((Byte)Value);
    Int16 IConvertible.ToInt16(IFormatProvider provider)
        => checked((Int16)Value);
    UInt16 IConvertible.ToUInt16(IFormatProvider provider)
        => checked((UInt16)Value);
    Int32 IConvertible.ToInt32(IFormatProvider provider)
        => checked((Int32)Value);
    UInt32 IConvertible.ToUInt32(IFormatProvider provider)
        => checked((UInt32)Value);
    Int64 IConvertible.ToInt64(IFormatProvider provider)
        => checked((Int64)Value);
    UInt64 IConvertible.ToUInt64(IFormatProvider provider)
        => checked((UInt64)Value);

    #endregion IConvertible
#if NET6_0_OR_GREATER
    public bool TryFormat (Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider)
    {
        if (format.Length > 0)
        {
            var rnf = new RomanNumeralFormatter();
            if (rnf.Supports(1, format, provider))
            {
                if (rnf.Supports(Value, format, provider))
                {
                    rnf.TryFormat(destination,out charsWritten, Value, format, provider);
                    return true;
                }
                return Value.TryFormat(destination, out charsWritten, "D".AsSpan(), provider);
            }
        }
        return Value.TryFormat(destination, out charsWritten, format, provider);
    }
#endif
}
public partial struct Int32Wrapper : IEquatable<Int32Wrapper>, IComparable, IComparable<Int32Wrapper>, IConvertible, IFormattable
#if NET6_0_OR_GREATER
    , ISpanFormattable
#endif
{
	public Int32Wrapper(Int32 value)
		=> Value = value;
        
    public static Int32Wrapper MinValue => Int32.MinValue;
    public static Int32Wrapper MaxValue => Int32.MaxValue;

	public Int32 Value { get; }

    public static implicit operator Int32(Int32Wrapper value)
        => value.Value;

    public static implicit operator Int32Wrapper(Int32 value)
        => new(value);

    public static bool operator ==(Int32Wrapper left, Int32Wrapper right)
        => left.Value == right.Value;

    public static bool operator !=(Int32Wrapper left, Int32Wrapper right)
        => left.Value != right.Value;

    public override bool Equals(object obj)
        => obj is Int32Wrapper other && Equals(other);

    public bool Equals(Int32Wrapper other)
        => this == other;

    public override int GetHashCode()
        => Value.GetHashCode();
    
    int IComparable.CompareTo(object obj)
        => Value.CompareTo(((Int32Wrapper)obj).Value);

    public int CompareTo(Int32Wrapper other)
        => Value.CompareTo(other.Value);

    public override string ToString()
        => Value.ToString();
        
    public string ToString(IFormatProvider provider)
        => Value.ToString(provider);
    
    public string ToString(string format)
        => ToString(format, CultureInfo.CurrentCulture);

    public string ToString(string format, IFormatProvider provider)
    {
        if (format?.Length > 0)
        {
            var fs = format.AsSpan();

            var rnf = new RomanNumeralFormatter();
            if (rnf.Supports(1, fs, provider))
            {
                if (rnf.Supports(Value, fs, provider))
                {
                    return rnf.ToString(Value, fs, provider);
                }
                return Value.ToString("D", provider);
            }
        }
        return Value.ToString(format, provider);
    }

    #region IConvertible

    TypeCode IConvertible.GetTypeCode() => Value.GetTypeCode();

    object IConvertible.ToType(Type conversionType, IFormatProvider provider)
    {
        return ((IConvertible)Value).ToType(conversionType, provider);
    }

    decimal IConvertible.ToDecimal(IFormatProvider provider)
        => Value;

    double IConvertible.ToDouble(IFormatProvider provider)
        => Value;

    float IConvertible.ToSingle(IFormatProvider provider)
        => Value;

    bool IConvertible.ToBoolean(IFormatProvider provider)
        => ((IConvertible)Value).ToBoolean(provider);

    char IConvertible.ToChar(IFormatProvider provider) => ((IConvertible)Value).ToChar(provider);

    DateTime IConvertible.ToDateTime(IFormatProvider provider) => ((IConvertible)Value).ToDateTime(provider);

    SByte IConvertible.ToSByte(IFormatProvider provider)
        => checked((SByte)Value);
    Byte IConvertible.ToByte(IFormatProvider provider)
        => checked((Byte)Value);
    Int16 IConvertible.ToInt16(IFormatProvider provider)
        => checked((Int16)Value);
    UInt16 IConvertible.ToUInt16(IFormatProvider provider)
        => checked((UInt16)Value);
    Int32 IConvertible.ToInt32(IFormatProvider provider)
        => checked((Int32)Value);
    UInt32 IConvertible.ToUInt32(IFormatProvider provider)
        => checked((UInt32)Value);
    Int64 IConvertible.ToInt64(IFormatProvider provider)
        => checked((Int64)Value);
    UInt64 IConvertible.ToUInt64(IFormatProvider provider)
        => checked((UInt64)Value);

    #endregion IConvertible
#if NET6_0_OR_GREATER
    public bool TryFormat (Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider)
    {
        if (format.Length > 0)
        {
            var rnf = new RomanNumeralFormatter();
            if (rnf.Supports(1, format, provider))
            {
                if (rnf.Supports(Value, format, provider))
                {
                    rnf.TryFormat(destination,out charsWritten, Value, format, provider);
                    return true;
                }
                return Value.TryFormat(destination, out charsWritten, "D".AsSpan(), provider);
            }
        }
        return Value.TryFormat(destination, out charsWritten, format, provider);
    }
#endif
}
public partial struct UInt32Wrapper : IEquatable<UInt32Wrapper>, IComparable, IComparable<UInt32Wrapper>, IConvertible, IFormattable
#if NET6_0_OR_GREATER
    , ISpanFormattable
#endif
{
	public UInt32Wrapper(UInt32 value)
		=> Value = value;
        
    public static UInt32Wrapper MinValue => UInt32.MinValue;
    public static UInt32Wrapper MaxValue => UInt32.MaxValue;

	public UInt32 Value { get; }

    public static implicit operator UInt32(UInt32Wrapper value)
        => value.Value;

    public static implicit operator UInt32Wrapper(UInt32 value)
        => new(value);

    public static bool operator ==(UInt32Wrapper left, UInt32Wrapper right)
        => left.Value == right.Value;

    public static bool operator !=(UInt32Wrapper left, UInt32Wrapper right)
        => left.Value != right.Value;

    public override bool Equals(object obj)
        => obj is UInt32Wrapper other && Equals(other);

    public bool Equals(UInt32Wrapper other)
        => this == other;

    public override int GetHashCode()
        => Value.GetHashCode();
    
    int IComparable.CompareTo(object obj)
        => Value.CompareTo(((UInt32Wrapper)obj).Value);

    public int CompareTo(UInt32Wrapper other)
        => Value.CompareTo(other.Value);

    public override string ToString()
        => Value.ToString();
        
    public string ToString(IFormatProvider provider)
        => Value.ToString(provider);
    
    public string ToString(string format)
        => ToString(format, CultureInfo.CurrentCulture);

    public string ToString(string format, IFormatProvider provider)
    {
        if (format?.Length > 0)
        {
            var fs = format.AsSpan();

            var rnf = new RomanNumeralFormatter();
            if (rnf.Supports(1, fs, provider))
            {
                if (rnf.Supports(Value, fs, provider))
                {
                    return rnf.ToString(Value, fs, provider);
                }
                return Value.ToString("D", provider);
            }
        }
        return Value.ToString(format, provider);
    }

    #region IConvertible

    TypeCode IConvertible.GetTypeCode() => Value.GetTypeCode();

    object IConvertible.ToType(Type conversionType, IFormatProvider provider)
    {
        return ((IConvertible)Value).ToType(conversionType, provider);
    }

    decimal IConvertible.ToDecimal(IFormatProvider provider)
        => Value;

    double IConvertible.ToDouble(IFormatProvider provider)
        => Value;

    float IConvertible.ToSingle(IFormatProvider provider)
        => Value;

    bool IConvertible.ToBoolean(IFormatProvider provider)
        => ((IConvertible)Value).ToBoolean(provider);

    char IConvertible.ToChar(IFormatProvider provider) => ((IConvertible)Value).ToChar(provider);

    DateTime IConvertible.ToDateTime(IFormatProvider provider) => ((IConvertible)Value).ToDateTime(provider);

    SByte IConvertible.ToSByte(IFormatProvider provider)
        => checked((SByte)Value);
    Byte IConvertible.ToByte(IFormatProvider provider)
        => checked((Byte)Value);
    Int16 IConvertible.ToInt16(IFormatProvider provider)
        => checked((Int16)Value);
    UInt16 IConvertible.ToUInt16(IFormatProvider provider)
        => checked((UInt16)Value);
    Int32 IConvertible.ToInt32(IFormatProvider provider)
        => checked((Int32)Value);
    UInt32 IConvertible.ToUInt32(IFormatProvider provider)
        => checked((UInt32)Value);
    Int64 IConvertible.ToInt64(IFormatProvider provider)
        => checked((Int64)Value);
    UInt64 IConvertible.ToUInt64(IFormatProvider provider)
        => checked((UInt64)Value);

    #endregion IConvertible
#if NET6_0_OR_GREATER
    public bool TryFormat (Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider)
    {
        if (format.Length > 0)
        {
            var rnf = new RomanNumeralFormatter();
            if (rnf.Supports(1, format, provider))
            {
                if (rnf.Supports(Value, format, provider))
                {
                    rnf.TryFormat(destination,out charsWritten, Value, format, provider);
                    return true;
                }
                return Value.TryFormat(destination, out charsWritten, "D".AsSpan(), provider);
            }
        }
        return Value.TryFormat(destination, out charsWritten, format, provider);
    }
#endif
}
public partial struct Int64Wrapper : IEquatable<Int64Wrapper>, IComparable, IComparable<Int64Wrapper>, IConvertible, IFormattable
#if NET6_0_OR_GREATER
    , ISpanFormattable
#endif
{
	public Int64Wrapper(Int64 value)
		=> Value = value;
        
    public static Int64Wrapper MinValue => Int64.MinValue;
    public static Int64Wrapper MaxValue => Int64.MaxValue;

	public Int64 Value { get; }

    public static implicit operator Int64(Int64Wrapper value)
        => value.Value;

    public static implicit operator Int64Wrapper(Int64 value)
        => new(value);

    public static bool operator ==(Int64Wrapper left, Int64Wrapper right)
        => left.Value == right.Value;

    public static bool operator !=(Int64Wrapper left, Int64Wrapper right)
        => left.Value != right.Value;

    public override bool Equals(object obj)
        => obj is Int64Wrapper other && Equals(other);

    public bool Equals(Int64Wrapper other)
        => this == other;

    public override int GetHashCode()
        => Value.GetHashCode();
    
    int IComparable.CompareTo(object obj)
        => Value.CompareTo(((Int64Wrapper)obj).Value);

    public int CompareTo(Int64Wrapper other)
        => Value.CompareTo(other.Value);

    public override string ToString()
        => Value.ToString();
        
    public string ToString(IFormatProvider provider)
        => Value.ToString(provider);
    
    public string ToString(string format)
        => ToString(format, CultureInfo.CurrentCulture);

    public string ToString(string format, IFormatProvider provider)
    {
        if (format?.Length > 0)
        {
            var fs = format.AsSpan();

            var rnf = new RomanNumeralFormatter();
            if (rnf.Supports(1, fs, provider))
            {
                if (rnf.Supports(Value, fs, provider))
                {
                    return rnf.ToString(Value, fs, provider);
                }
                return Value.ToString("D", provider);
            }
        }
        return Value.ToString(format, provider);
    }

    #region IConvertible

    TypeCode IConvertible.GetTypeCode() => Value.GetTypeCode();

    object IConvertible.ToType(Type conversionType, IFormatProvider provider)
    {
        return ((IConvertible)Value).ToType(conversionType, provider);
    }

    decimal IConvertible.ToDecimal(IFormatProvider provider)
        => Value;

    double IConvertible.ToDouble(IFormatProvider provider)
        => Value;

    float IConvertible.ToSingle(IFormatProvider provider)
        => Value;

    bool IConvertible.ToBoolean(IFormatProvider provider)
        => ((IConvertible)Value).ToBoolean(provider);

    char IConvertible.ToChar(IFormatProvider provider) => ((IConvertible)Value).ToChar(provider);

    DateTime IConvertible.ToDateTime(IFormatProvider provider) => ((IConvertible)Value).ToDateTime(provider);

    SByte IConvertible.ToSByte(IFormatProvider provider)
        => checked((SByte)Value);
    Byte IConvertible.ToByte(IFormatProvider provider)
        => checked((Byte)Value);
    Int16 IConvertible.ToInt16(IFormatProvider provider)
        => checked((Int16)Value);
    UInt16 IConvertible.ToUInt16(IFormatProvider provider)
        => checked((UInt16)Value);
    Int32 IConvertible.ToInt32(IFormatProvider provider)
        => checked((Int32)Value);
    UInt32 IConvertible.ToUInt32(IFormatProvider provider)
        => checked((UInt32)Value);
    Int64 IConvertible.ToInt64(IFormatProvider provider)
        => checked((Int64)Value);
    UInt64 IConvertible.ToUInt64(IFormatProvider provider)
        => checked((UInt64)Value);

    #endregion IConvertible
#if NET6_0_OR_GREATER
    public bool TryFormat (Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider)
    {
        if (format.Length > 0)
        {
            var rnf = new RomanNumeralFormatter();
            if (rnf.Supports(1, format, provider))
            {
                if (rnf.Supports(Value, format, provider))
                {
                    rnf.TryFormat(destination,out charsWritten, Value, format, provider);
                    return true;
                }
                return Value.TryFormat(destination, out charsWritten, "D".AsSpan(), provider);
            }
        }
        return Value.TryFormat(destination, out charsWritten, format, provider);
    }
#endif
}
public partial struct UInt64Wrapper : IEquatable<UInt64Wrapper>, IComparable, IComparable<UInt64Wrapper>, IConvertible, IFormattable
#if NET6_0_OR_GREATER
    , ISpanFormattable
#endif
{
	public UInt64Wrapper(UInt64 value)
		=> Value = value;
        
    public static UInt64Wrapper MinValue => UInt64.MinValue;
    public static UInt64Wrapper MaxValue => UInt64.MaxValue;

	public UInt64 Value { get; }

    public static implicit operator UInt64(UInt64Wrapper value)
        => value.Value;

    public static implicit operator UInt64Wrapper(UInt64 value)
        => new(value);

    public static bool operator ==(UInt64Wrapper left, UInt64Wrapper right)
        => left.Value == right.Value;

    public static bool operator !=(UInt64Wrapper left, UInt64Wrapper right)
        => left.Value != right.Value;

    public override bool Equals(object obj)
        => obj is UInt64Wrapper other && Equals(other);

    public bool Equals(UInt64Wrapper other)
        => this == other;

    public override int GetHashCode()
        => Value.GetHashCode();
    
    int IComparable.CompareTo(object obj)
        => Value.CompareTo(((UInt64Wrapper)obj).Value);

    public int CompareTo(UInt64Wrapper other)
        => Value.CompareTo(other.Value);

    public override string ToString()
        => Value.ToString();
        
    public string ToString(IFormatProvider provider)
        => Value.ToString(provider);
    
    public string ToString(string format)
        => ToString(format, CultureInfo.CurrentCulture);

    public string ToString(string format, IFormatProvider provider)
    {
        if (format?.Length > 0)
        {
            var fs = format.AsSpan();

            var rnf = new RomanNumeralFormatter();
            if (rnf.Supports(1, fs, provider))
            {
                if (rnf.Supports(Value, fs, provider))
                {
                    return rnf.ToString(Value, fs, provider);
                }
                return Value.ToString("D", provider);
            }
        }
        return Value.ToString(format, provider);
    }

    #region IConvertible

    TypeCode IConvertible.GetTypeCode() => Value.GetTypeCode();

    object IConvertible.ToType(Type conversionType, IFormatProvider provider)
    {
        return ((IConvertible)Value).ToType(conversionType, provider);
    }

    decimal IConvertible.ToDecimal(IFormatProvider provider)
        => Value;

    double IConvertible.ToDouble(IFormatProvider provider)
        => Value;

    float IConvertible.ToSingle(IFormatProvider provider)
        => Value;

    bool IConvertible.ToBoolean(IFormatProvider provider)
        => ((IConvertible)Value).ToBoolean(provider);

    char IConvertible.ToChar(IFormatProvider provider) => ((IConvertible)Value).ToChar(provider);

    DateTime IConvertible.ToDateTime(IFormatProvider provider) => ((IConvertible)Value).ToDateTime(provider);

    SByte IConvertible.ToSByte(IFormatProvider provider)
        => checked((SByte)Value);
    Byte IConvertible.ToByte(IFormatProvider provider)
        => checked((Byte)Value);
    Int16 IConvertible.ToInt16(IFormatProvider provider)
        => checked((Int16)Value);
    UInt16 IConvertible.ToUInt16(IFormatProvider provider)
        => checked((UInt16)Value);
    Int32 IConvertible.ToInt32(IFormatProvider provider)
        => checked((Int32)Value);
    UInt32 IConvertible.ToUInt32(IFormatProvider provider)
        => checked((UInt32)Value);
    Int64 IConvertible.ToInt64(IFormatProvider provider)
        => checked((Int64)Value);
    UInt64 IConvertible.ToUInt64(IFormatProvider provider)
        => checked((UInt64)Value);

    #endregion IConvertible
#if NET6_0_OR_GREATER
    public bool TryFormat (Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider)
    {
        if (format.Length > 0)
        {
            var rnf = new RomanNumeralFormatter();
            if (rnf.Supports(1, format, provider))
            {
                if (rnf.Supports(Value, format, provider))
                {
                    rnf.TryFormat(destination,out charsWritten, Value, format, provider);
                    return true;
                }
                return Value.TryFormat(destination, out charsWritten, "D".AsSpan(), provider);
            }
        }
        return Value.TryFormat(destination, out charsWritten, format, provider);
    }
#endif
}
