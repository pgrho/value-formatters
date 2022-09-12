using System.IO;

namespace Shipwreck.ValueFormatters.Composition;

partial struct Year1Specifier : IDateTimeDigitSpecifier
{
    public void WriteTo(TextWriter writer, DateTime value, IFormatProvider formatProvider)
        => DateTimeDigitSpecifier.WriteToCore(this, writer, value);

    public void WriteTo(TextWriter writer, DateTimeOffset value, IFormatProvider formatProvider)
        => DateTimeDigitSpecifier.WriteToCore(this, writer, value);

    public bool TryFormat(Span<char> destination, out int charsWritten, DateTime value, IFormatProvider formatProvider)
        => DateTimeDigitSpecifier.TryFormatCore(this, destination, out charsWritten, value);

    public bool TryFormat(Span<char> destination, out int charsWritten, DateTimeOffset value, IFormatProvider formatProvider)
        => DateTimeDigitSpecifier.TryFormatCore(this, destination, out charsWritten, value);
}
partial struct Year2Specifier : IDateTimeDigitSpecifier
{
    public void WriteTo(TextWriter writer, DateTime value, IFormatProvider formatProvider)
        => DateTimeDigitSpecifier.WriteToCore(this, writer, value);

    public void WriteTo(TextWriter writer, DateTimeOffset value, IFormatProvider formatProvider)
        => DateTimeDigitSpecifier.WriteToCore(this, writer, value);

    public bool TryFormat(Span<char> destination, out int charsWritten, DateTime value, IFormatProvider formatProvider)
        => DateTimeDigitSpecifier.TryFormatCore(this, destination, out charsWritten, value);

    public bool TryFormat(Span<char> destination, out int charsWritten, DateTimeOffset value, IFormatProvider formatProvider)
        => DateTimeDigitSpecifier.TryFormatCore(this, destination, out charsWritten, value);
}
partial struct Year3Specifier : IDateTimeDigitSpecifier
{
    public void WriteTo(TextWriter writer, DateTime value, IFormatProvider formatProvider)
        => DateTimeDigitSpecifier.WriteToCore(this, writer, value);

    public void WriteTo(TextWriter writer, DateTimeOffset value, IFormatProvider formatProvider)
        => DateTimeDigitSpecifier.WriteToCore(this, writer, value);

    public bool TryFormat(Span<char> destination, out int charsWritten, DateTime value, IFormatProvider formatProvider)
        => DateTimeDigitSpecifier.TryFormatCore(this, destination, out charsWritten, value);

    public bool TryFormat(Span<char> destination, out int charsWritten, DateTimeOffset value, IFormatProvider formatProvider)
        => DateTimeDigitSpecifier.TryFormatCore(this, destination, out charsWritten, value);
}
partial struct Year4Specifier : IDateTimeDigitSpecifier
{
    public void WriteTo(TextWriter writer, DateTime value, IFormatProvider formatProvider)
        => DateTimeDigitSpecifier.WriteToCore(this, writer, value);

    public void WriteTo(TextWriter writer, DateTimeOffset value, IFormatProvider formatProvider)
        => DateTimeDigitSpecifier.WriteToCore(this, writer, value);

    public bool TryFormat(Span<char> destination, out int charsWritten, DateTime value, IFormatProvider formatProvider)
        => DateTimeDigitSpecifier.TryFormatCore(this, destination, out charsWritten, value);

    public bool TryFormat(Span<char> destination, out int charsWritten, DateTimeOffset value, IFormatProvider formatProvider)
        => DateTimeDigitSpecifier.TryFormatCore(this, destination, out charsWritten, value);
}
partial struct Year5Specifier : IDateTimeDigitSpecifier
{
    public void WriteTo(TextWriter writer, DateTime value, IFormatProvider formatProvider)
        => DateTimeDigitSpecifier.WriteToCore(this, writer, value);

    public void WriteTo(TextWriter writer, DateTimeOffset value, IFormatProvider formatProvider)
        => DateTimeDigitSpecifier.WriteToCore(this, writer, value);

    public bool TryFormat(Span<char> destination, out int charsWritten, DateTime value, IFormatProvider formatProvider)
        => DateTimeDigitSpecifier.TryFormatCore(this, destination, out charsWritten, value);

    public bool TryFormat(Span<char> destination, out int charsWritten, DateTimeOffset value, IFormatProvider formatProvider)
        => DateTimeDigitSpecifier.TryFormatCore(this, destination, out charsWritten, value);
}
partial struct Month1Specifier : IDateTimeDigitSpecifier
{
    public void WriteTo(TextWriter writer, DateTime value, IFormatProvider formatProvider)
        => DateTimeDigitSpecifier.WriteToCore(this, writer, value);

    public void WriteTo(TextWriter writer, DateTimeOffset value, IFormatProvider formatProvider)
        => DateTimeDigitSpecifier.WriteToCore(this, writer, value);

    public bool TryFormat(Span<char> destination, out int charsWritten, DateTime value, IFormatProvider formatProvider)
        => DateTimeDigitSpecifier.TryFormatCore(this, destination, out charsWritten, value);

    public bool TryFormat(Span<char> destination, out int charsWritten, DateTimeOffset value, IFormatProvider formatProvider)
        => DateTimeDigitSpecifier.TryFormatCore(this, destination, out charsWritten, value);
}
partial struct Month2Specifier : IDateTimeDigitSpecifier
{
    public void WriteTo(TextWriter writer, DateTime value, IFormatProvider formatProvider)
        => DateTimeDigitSpecifier.WriteToCore(this, writer, value);

    public void WriteTo(TextWriter writer, DateTimeOffset value, IFormatProvider formatProvider)
        => DateTimeDigitSpecifier.WriteToCore(this, writer, value);

    public bool TryFormat(Span<char> destination, out int charsWritten, DateTime value, IFormatProvider formatProvider)
        => DateTimeDigitSpecifier.TryFormatCore(this, destination, out charsWritten, value);

    public bool TryFormat(Span<char> destination, out int charsWritten, DateTimeOffset value, IFormatProvider formatProvider)
        => DateTimeDigitSpecifier.TryFormatCore(this, destination, out charsWritten, value);
}
partial struct Day1Specifier : IDateTimeDigitSpecifier
{
    public void WriteTo(TextWriter writer, DateTime value, IFormatProvider formatProvider)
        => DateTimeDigitSpecifier.WriteToCore(this, writer, value);

    public void WriteTo(TextWriter writer, DateTimeOffset value, IFormatProvider formatProvider)
        => DateTimeDigitSpecifier.WriteToCore(this, writer, value);

    public bool TryFormat(Span<char> destination, out int charsWritten, DateTime value, IFormatProvider formatProvider)
        => DateTimeDigitSpecifier.TryFormatCore(this, destination, out charsWritten, value);

    public bool TryFormat(Span<char> destination, out int charsWritten, DateTimeOffset value, IFormatProvider formatProvider)
        => DateTimeDigitSpecifier.TryFormatCore(this, destination, out charsWritten, value);
}
partial struct Day2Specifier : IDateTimeDigitSpecifier
{
    public void WriteTo(TextWriter writer, DateTime value, IFormatProvider formatProvider)
        => DateTimeDigitSpecifier.WriteToCore(this, writer, value);

    public void WriteTo(TextWriter writer, DateTimeOffset value, IFormatProvider formatProvider)
        => DateTimeDigitSpecifier.WriteToCore(this, writer, value);

    public bool TryFormat(Span<char> destination, out int charsWritten, DateTime value, IFormatProvider formatProvider)
        => DateTimeDigitSpecifier.TryFormatCore(this, destination, out charsWritten, value);

    public bool TryFormat(Span<char> destination, out int charsWritten, DateTimeOffset value, IFormatProvider formatProvider)
        => DateTimeDigitSpecifier.TryFormatCore(this, destination, out charsWritten, value);
}
partial struct Hour1Specifier : IDateTimeDigitSpecifier
{
    public void WriteTo(TextWriter writer, DateTime value, IFormatProvider formatProvider)
        => DateTimeDigitSpecifier.WriteToCore(this, writer, value);

    public void WriteTo(TextWriter writer, DateTimeOffset value, IFormatProvider formatProvider)
        => DateTimeDigitSpecifier.WriteToCore(this, writer, value);

    public bool TryFormat(Span<char> destination, out int charsWritten, DateTime value, IFormatProvider formatProvider)
        => DateTimeDigitSpecifier.TryFormatCore(this, destination, out charsWritten, value);

    public bool TryFormat(Span<char> destination, out int charsWritten, DateTimeOffset value, IFormatProvider formatProvider)
        => DateTimeDigitSpecifier.TryFormatCore(this, destination, out charsWritten, value);
}
partial struct Hour2Specifier : IDateTimeDigitSpecifier
{
    public void WriteTo(TextWriter writer, DateTime value, IFormatProvider formatProvider)
        => DateTimeDigitSpecifier.WriteToCore(this, writer, value);

    public void WriteTo(TextWriter writer, DateTimeOffset value, IFormatProvider formatProvider)
        => DateTimeDigitSpecifier.WriteToCore(this, writer, value);

    public bool TryFormat(Span<char> destination, out int charsWritten, DateTime value, IFormatProvider formatProvider)
        => DateTimeDigitSpecifier.TryFormatCore(this, destination, out charsWritten, value);

    public bool TryFormat(Span<char> destination, out int charsWritten, DateTimeOffset value, IFormatProvider formatProvider)
        => DateTimeDigitSpecifier.TryFormatCore(this, destination, out charsWritten, value);
}
partial struct TwelveClockHour1Specifier : IDateTimeDigitSpecifier
{
    public void WriteTo(TextWriter writer, DateTime value, IFormatProvider formatProvider)
        => DateTimeDigitSpecifier.WriteToCore(this, writer, value);

    public void WriteTo(TextWriter writer, DateTimeOffset value, IFormatProvider formatProvider)
        => DateTimeDigitSpecifier.WriteToCore(this, writer, value);

    public bool TryFormat(Span<char> destination, out int charsWritten, DateTime value, IFormatProvider formatProvider)
        => DateTimeDigitSpecifier.TryFormatCore(this, destination, out charsWritten, value);

    public bool TryFormat(Span<char> destination, out int charsWritten, DateTimeOffset value, IFormatProvider formatProvider)
        => DateTimeDigitSpecifier.TryFormatCore(this, destination, out charsWritten, value);
}
partial struct TwelveClockHour2Specifier : IDateTimeDigitSpecifier
{
    public void WriteTo(TextWriter writer, DateTime value, IFormatProvider formatProvider)
        => DateTimeDigitSpecifier.WriteToCore(this, writer, value);

    public void WriteTo(TextWriter writer, DateTimeOffset value, IFormatProvider formatProvider)
        => DateTimeDigitSpecifier.WriteToCore(this, writer, value);

    public bool TryFormat(Span<char> destination, out int charsWritten, DateTime value, IFormatProvider formatProvider)
        => DateTimeDigitSpecifier.TryFormatCore(this, destination, out charsWritten, value);

    public bool TryFormat(Span<char> destination, out int charsWritten, DateTimeOffset value, IFormatProvider formatProvider)
        => DateTimeDigitSpecifier.TryFormatCore(this, destination, out charsWritten, value);
}
partial struct Minute1Specifier : IDateTimeDigitSpecifier
{
    public void WriteTo(TextWriter writer, DateTime value, IFormatProvider formatProvider)
        => DateTimeDigitSpecifier.WriteToCore(this, writer, value);

    public void WriteTo(TextWriter writer, DateTimeOffset value, IFormatProvider formatProvider)
        => DateTimeDigitSpecifier.WriteToCore(this, writer, value);

    public bool TryFormat(Span<char> destination, out int charsWritten, DateTime value, IFormatProvider formatProvider)
        => DateTimeDigitSpecifier.TryFormatCore(this, destination, out charsWritten, value);

    public bool TryFormat(Span<char> destination, out int charsWritten, DateTimeOffset value, IFormatProvider formatProvider)
        => DateTimeDigitSpecifier.TryFormatCore(this, destination, out charsWritten, value);
}
partial struct Minute2Specifier : IDateTimeDigitSpecifier
{
    public void WriteTo(TextWriter writer, DateTime value, IFormatProvider formatProvider)
        => DateTimeDigitSpecifier.WriteToCore(this, writer, value);

    public void WriteTo(TextWriter writer, DateTimeOffset value, IFormatProvider formatProvider)
        => DateTimeDigitSpecifier.WriteToCore(this, writer, value);

    public bool TryFormat(Span<char> destination, out int charsWritten, DateTime value, IFormatProvider formatProvider)
        => DateTimeDigitSpecifier.TryFormatCore(this, destination, out charsWritten, value);

    public bool TryFormat(Span<char> destination, out int charsWritten, DateTimeOffset value, IFormatProvider formatProvider)
        => DateTimeDigitSpecifier.TryFormatCore(this, destination, out charsWritten, value);
}
partial struct Second1Specifier : IDateTimeDigitSpecifier
{
    public void WriteTo(TextWriter writer, DateTime value, IFormatProvider formatProvider)
        => DateTimeDigitSpecifier.WriteToCore(this, writer, value);

    public void WriteTo(TextWriter writer, DateTimeOffset value, IFormatProvider formatProvider)
        => DateTimeDigitSpecifier.WriteToCore(this, writer, value);

    public bool TryFormat(Span<char> destination, out int charsWritten, DateTime value, IFormatProvider formatProvider)
        => DateTimeDigitSpecifier.TryFormatCore(this, destination, out charsWritten, value);

    public bool TryFormat(Span<char> destination, out int charsWritten, DateTimeOffset value, IFormatProvider formatProvider)
        => DateTimeDigitSpecifier.TryFormatCore(this, destination, out charsWritten, value);
}
partial struct Second2Specifier : IDateTimeDigitSpecifier
{
    public void WriteTo(TextWriter writer, DateTime value, IFormatProvider formatProvider)
        => DateTimeDigitSpecifier.WriteToCore(this, writer, value);

    public void WriteTo(TextWriter writer, DateTimeOffset value, IFormatProvider formatProvider)
        => DateTimeDigitSpecifier.WriteToCore(this, writer, value);

    public bool TryFormat(Span<char> destination, out int charsWritten, DateTime value, IFormatProvider formatProvider)
        => DateTimeDigitSpecifier.TryFormatCore(this, destination, out charsWritten, value);

    public bool TryFormat(Span<char> destination, out int charsWritten, DateTimeOffset value, IFormatProvider formatProvider)
        => DateTimeDigitSpecifier.TryFormatCore(this, destination, out charsWritten, value);
}
partial struct MonthName3Specifier : IDateTimeArraySpecifier
{
    public void WriteTo(TextWriter writer, DateTime value, IFormatProvider formatProvider)
        => DateTimeArraySpecifier.WriteToCore(this, writer, value, formatProvider);

    public void WriteTo(TextWriter writer, DateTimeOffset value, IFormatProvider formatProvider)
        => DateTimeArraySpecifier.WriteToCore(this, writer, value, formatProvider);

    public bool TryFormat(Span<char> destination, out int charsWritten, DateTime value, IFormatProvider formatProvider)
        => DateTimeArraySpecifier.TryFormatCore(this, destination, out charsWritten, value, formatProvider);

    public bool TryFormat(Span<char> destination, out int charsWritten, DateTimeOffset value, IFormatProvider formatProvider)
        => DateTimeArraySpecifier.TryFormatCore(this, destination, out charsWritten, value, formatProvider);
}
partial struct MonthName4Specifier : IDateTimeArraySpecifier
{
    public void WriteTo(TextWriter writer, DateTime value, IFormatProvider formatProvider)
        => DateTimeArraySpecifier.WriteToCore(this, writer, value, formatProvider);

    public void WriteTo(TextWriter writer, DateTimeOffset value, IFormatProvider formatProvider)
        => DateTimeArraySpecifier.WriteToCore(this, writer, value, formatProvider);

    public bool TryFormat(Span<char> destination, out int charsWritten, DateTime value, IFormatProvider formatProvider)
        => DateTimeArraySpecifier.TryFormatCore(this, destination, out charsWritten, value, formatProvider);

    public bool TryFormat(Span<char> destination, out int charsWritten, DateTimeOffset value, IFormatProvider formatProvider)
        => DateTimeArraySpecifier.TryFormatCore(this, destination, out charsWritten, value, formatProvider);
}
partial struct DayName3Specifier : IDateTimeArraySpecifier
{
    public void WriteTo(TextWriter writer, DateTime value, IFormatProvider formatProvider)
        => DateTimeArraySpecifier.WriteToCore(this, writer, value, formatProvider);

    public void WriteTo(TextWriter writer, DateTimeOffset value, IFormatProvider formatProvider)
        => DateTimeArraySpecifier.WriteToCore(this, writer, value, formatProvider);

    public bool TryFormat(Span<char> destination, out int charsWritten, DateTime value, IFormatProvider formatProvider)
        => DateTimeArraySpecifier.TryFormatCore(this, destination, out charsWritten, value, formatProvider);

    public bool TryFormat(Span<char> destination, out int charsWritten, DateTimeOffset value, IFormatProvider formatProvider)
        => DateTimeArraySpecifier.TryFormatCore(this, destination, out charsWritten, value, formatProvider);
}
partial struct DayName4Specifier : IDateTimeArraySpecifier
{
    public void WriteTo(TextWriter writer, DateTime value, IFormatProvider formatProvider)
        => DateTimeArraySpecifier.WriteToCore(this, writer, value, formatProvider);

    public void WriteTo(TextWriter writer, DateTimeOffset value, IFormatProvider formatProvider)
        => DateTimeArraySpecifier.WriteToCore(this, writer, value, formatProvider);

    public bool TryFormat(Span<char> destination, out int charsWritten, DateTime value, IFormatProvider formatProvider)
        => DateTimeArraySpecifier.TryFormatCore(this, destination, out charsWritten, value, formatProvider);

    public bool TryFormat(Span<char> destination, out int charsWritten, DateTimeOffset value, IFormatProvider formatProvider)
        => DateTimeArraySpecifier.TryFormatCore(this, destination, out charsWritten, value, formatProvider);
}
public partial struct CapitalTSpecifier<T> : ICharLiteralSpecifier<T>
{
    public char Char => 'T';

    public void WriteTo(TextWriter writer, T value, IFormatProvider formatProvider)
        => CharLiteralSpecifier.WriteToCore(this, writer, value);

    public bool TryFormat(Span<char> destination, out int charsWritten, T value, IFormatProvider formatProvider)
        => CharLiteralSpecifier.TryFormatCore(this, destination, out charsWritten, value);
}
public partial struct ColonSpecifier<T> : ICharLiteralSpecifier<T>
{
    public char Char => ':';

    public void WriteTo(TextWriter writer, T value, IFormatProvider formatProvider)
        => CharLiteralSpecifier.WriteToCore(this, writer, value);

    public bool TryFormat(Span<char> destination, out int charsWritten, T value, IFormatProvider formatProvider)
        => CharLiteralSpecifier.TryFormatCore(this, destination, out charsWritten, value);
}
public partial struct DotSpecifier<T> : ICharLiteralSpecifier<T>
{
    public char Char => '.';

    public void WriteTo(TextWriter writer, T value, IFormatProvider formatProvider)
        => CharLiteralSpecifier.WriteToCore(this, writer, value);

    public bool TryFormat(Span<char> destination, out int charsWritten, T value, IFormatProvider formatProvider)
        => CharLiteralSpecifier.TryFormatCore(this, destination, out charsWritten, value);
}
public partial struct HyphenSpecifier<T> : ICharLiteralSpecifier<T>
{
    public char Char => '-';

    public void WriteTo(TextWriter writer, T value, IFormatProvider formatProvider)
        => CharLiteralSpecifier.WriteToCore(this, writer, value);

    public bool TryFormat(Span<char> destination, out int charsWritten, T value, IFormatProvider formatProvider)
        => CharLiteralSpecifier.TryFormatCore(this, destination, out charsWritten, value);
}
public partial struct SlashSpecifier<T> : ICharLiteralSpecifier<T>
{
    public char Char => '/';

    public void WriteTo(TextWriter writer, T value, IFormatProvider formatProvider)
        => CharLiteralSpecifier.WriteToCore(this, writer, value);

    public bool TryFormat(Span<char> destination, out int charsWritten, T value, IFormatProvider formatProvider)
        => CharLiteralSpecifier.TryFormatCore(this, destination, out charsWritten, value);
}
public partial struct WhitespaceSpecifier<T> : ICharLiteralSpecifier<T>
{
    public char Char => ' ';

    public void WriteTo(TextWriter writer, T value, IFormatProvider formatProvider)
        => CharLiteralSpecifier.WriteToCore(this, writer, value);

    public bool TryFormat(Span<char> destination, out int charsWritten, T value, IFormatProvider formatProvider)
        => CharLiteralSpecifier.TryFormatCore(this, destination, out charsWritten, value);
}
