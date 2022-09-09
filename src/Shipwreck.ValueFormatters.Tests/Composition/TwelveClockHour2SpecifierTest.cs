namespace Shipwreck.ValueFormatters.Composition;

public class TwelveClockHour2SpecifierTest
{
    [Theory]
    [InlineData(0, "00")]
    [InlineData(1, "01")]
    [InlineData(9, "09")]
    [InlineData(10, "10")]
    [InlineData(11, "11")]
    [InlineData(12, "00")]
    [InlineData(21, "09")]
    [InlineData(22, "10")]
    [InlineData(23, "11")]
    public void Test(int n, string expected)
    {
        static DateTime create(int n)
            => new DateTime(2000, 1, 1, n, 12, 34);

        Assert.Equal(expected, new TwelveClockHour2Specifier().Format(create(n)));
    }
}
