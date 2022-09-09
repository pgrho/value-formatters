namespace Shipwreck.ValueFormatters.Composition;

public partial struct MonthName4Specifier
{
    public int GetIndex(DateTime value) => value.Month - 1;

    public string[] GetArray(DateTimeFormatInfo dateTimeFormatInfo) => dateTimeFormatInfo.MonthNames;
}
