namespace Shipwreck.ValueFormatters.Composition;

public partial struct MonthName3Specifier
{
    public int GetIndex(DateTime value) => value.Month - 1;

    public string[] GetArray(DateTimeFormatInfo dateTimeFormatInfo) => dateTimeFormatInfo.AbbreviatedMonthNames;
}
