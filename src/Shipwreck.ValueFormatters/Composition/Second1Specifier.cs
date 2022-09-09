namespace Shipwreck.ValueFormatters.Composition;

public partial struct Second1Specifier
{
    public byte MinimumLength => 1;
    public byte MaximumLength => 2;

    public int GetNumber(DateTime value) => value.Second;
}
