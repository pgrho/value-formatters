namespace Shipwreck.ValueFormatters.Composition;

public partial struct DayName4Specifier
{
    public int GetIndex(DateTime value) => (int)value.DayOfWeek;

    public string[] GetArray(DateTimeFormatInfo dateTimeFormatInfo) => dateTimeFormatInfo.DayNames;
}
