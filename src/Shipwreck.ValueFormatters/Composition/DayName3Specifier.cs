namespace Shipwreck.ValueFormatters.Composition;

public partial struct DayName3Specifier
{
    public int GetIndex(DateTime value) => (int)value.DayOfWeek;

    public string[] GetArray(DateTimeFormatInfo dateTimeFormatInfo) => dateTimeFormatInfo.AbbreviatedDayNames;
}
