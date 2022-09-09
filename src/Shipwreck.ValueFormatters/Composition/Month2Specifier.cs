namespace Shipwreck.ValueFormatters.Composition;

public partial struct Month2Specifier
{
    public byte MinimumLength => 2;
    public byte MaximumLength => 2;

    public int GetNumber(DateTime value) => value.Month;
}
