namespace Shipwreck.ValueFormatters.Composition;

public class TwelveClockHour1SpecifierTest
{
    [Theory]
    [InlineData(0, "0")]
    [InlineData(1, "1")]
    [InlineData(9, "9")]
    [InlineData(10, "10")]
    [InlineData(11, "11")]
    [InlineData(12, "0")]
    [InlineData(21, "9")]
    [InlineData(22, "10")]
    [InlineData(23, "11")]
    public void Test(int n, string expected)
    {
        static DateTime create(int n)
            => new DateTime(2000, 1, 1, n, 12, 34);

        Assert.Equal(expected, new TwelveClockHour1Specifier().Format(create(n)));
    }
}
