namespace Shipwreck.ValueFormatters.Composition;

public partial struct Day1Specifier
{
    public byte MinimumLength => 1;
    public byte MaximumLength => 2;

    public int GetNumber(DateTime value) => value.Day;
}
