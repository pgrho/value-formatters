namespace Shipwreck.ValueFormatters.Composition;

public partial struct Year5Specifier
{
    public byte MinimumLength => 5;
    public byte MaximumLength => 5;

    public int GetNumber(DateTime value) => value.Year;
}
