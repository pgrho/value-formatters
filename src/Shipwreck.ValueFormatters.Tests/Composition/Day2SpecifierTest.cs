namespace Shipwreck.ValueFormatters.Composition;

public class Day2SpecifierTest
{
    [Theory]
    [InlineData(1, "01")]
    [InlineData(9, "09")]
    [InlineData(10, "10")]
    [InlineData(31, "31")]
    public void Test(int n, string expected)
    {
        static DateTime create(int n)
            => new DateTime(2000, 1, n);

        Assert.Equal(expected, new Day2Specifier().Format(create(n)));
    }
}
