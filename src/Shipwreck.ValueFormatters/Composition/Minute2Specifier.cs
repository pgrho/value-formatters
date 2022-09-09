namespace Shipwreck.ValueFormatters.Composition;

public partial struct Minute2Specifier
{
    public byte MinimumLength => 2;
    public byte MaximumLength => 2;

    public int GetNumber(DateTime value) => value.Minute;
}
