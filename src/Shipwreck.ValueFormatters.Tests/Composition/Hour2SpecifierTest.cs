namespace Shipwreck.ValueFormatters.Composition;

public class Hour2SpecifierTest
{
    [Theory]
    [InlineData(0, "00")]
    [InlineData(1, "01")]
    [InlineData(9, "09")]
    [InlineData(10, "10")]
    [InlineData(23, "23")]
    public void Test(int n, string expected)
    {
        static DateTime create(int n)
            => new DateTime(2000, 1, 1, n, 12, 34);

        Assert.Equal(expected, new Hour2Specifier().Format(create(n)));
    }
}
