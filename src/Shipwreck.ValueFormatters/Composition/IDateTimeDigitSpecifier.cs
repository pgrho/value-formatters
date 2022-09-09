namespace Shipwreck.ValueFormatters.Composition;

internal interface IDateTimeDigitSpecifier : IStructFormatSpecifier<DateTime>, IStructFormatSpecifier<DateTimeOffset>
{
    byte MinimumLength { get; }
    byte MaximumLength { get; }

    int GetNumber(DateTime value);
}
