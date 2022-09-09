namespace Shipwreck.ValueFormatters.Composition;

internal interface IDateTimeDigitSpecifier : IFormatSpecifier<DateTime>, IFormatSpecifier<DateTimeOffset>
{
    byte MinimumLength { get; }
    byte MaximumLength { get; }

    int GetNumber(DateTime value);
}
