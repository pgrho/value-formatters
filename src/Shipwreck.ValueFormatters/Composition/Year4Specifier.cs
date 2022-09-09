namespace Shipwreck.ValueFormatters.Composition;

public partial struct Year4Specifier
{
    public byte MinimumLength => 4;
    public byte MaximumLength => 4;

    public int GetNumber(DateTime value) => value.Year;
}
