namespace Shipwreck.ValueFormatters.Composition;

public class Second2SpecifierTest
{
    [Theory]
    [InlineData(0, "00")]
    [InlineData(1, "01")]
    [InlineData(9, "09")]
    [InlineData(10, "10")]
    [InlineData(59, "59")]
    public void Test(int n, string expected)
    {
        static DateTime create(int n)
            => new DateTime(2000, 1, 1, 0, 0, n);

        Assert.Equal(expected, new Second2Specifier().Format(create(n)));
    }
}
