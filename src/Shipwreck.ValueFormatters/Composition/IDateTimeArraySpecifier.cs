namespace Shipwreck.ValueFormatters.Composition;

internal interface IDateTimeArraySpecifier : IFormatSpecifier<DateTime>, IFormatSpecifier<DateTimeOffset>
{
    int GetIndex(DateTime value);

    string[] GetArray(DateTimeFormatInfo dateTimeFormatInfo);
}
