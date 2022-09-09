namespace Shipwreck.ValueFormatters.Composition;

public partial struct Year3Specifier
{
    public byte MinimumLength => 3;
    public byte MaximumLength => 4;

    public int GetNumber(DateTime value) => value.Year;
}
