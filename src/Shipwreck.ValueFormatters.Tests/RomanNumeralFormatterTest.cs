namespace Shipwreck.ValueFormatters;

public class RomanNumeralFormatterTest
{
    [Theory]
    [InlineData("L", 1, "I")]
    [InlineData("L", 3, "III")]
    [InlineData("LS", 4, "IV")]
    [InlineData("LA", 4, "IIII")]
    [InlineData("L", 9, "IX")]
    [InlineData("l", 9, "ix")]
    [InlineData("LS", 9, "IX")]
    [InlineData("ls", 9, "ix")]
    [InlineData("LA", 9, "VIIII")]
    [InlineData("la", 9, "viiii")]
    [InlineData("LS", 3999, "MMMCMXCIX")]
    [InlineData("LA", 3999, "MMMDCCCCLXXXXVIIII")]
    public void Test(string format, int value, string expected)
        => Assert.Equal(expected, new RomanNumeralFormatter().ToString(value, format));
}
