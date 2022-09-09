namespace Shipwreck.ValueFormatters.Composition;

internal interface IDateTimeArraySpecifier : IStructFormatSpecifier<DateTime>, IStructFormatSpecifier<DateTimeOffset>
{
    int GetIndex(DateTime value);

    string[] GetArray(DateTimeFormatInfo dateTimeFormatInfo);
}
