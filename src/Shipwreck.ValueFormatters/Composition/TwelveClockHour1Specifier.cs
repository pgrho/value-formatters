namespace Shipwreck.ValueFormatters.Composition;

public partial struct TwelveClockHour1Specifier
{
    public byte MinimumLength => 1;
    public byte MaximumLength => 2;

    public int GetNumber(DateTime value) => value.Hour % 12;
}
