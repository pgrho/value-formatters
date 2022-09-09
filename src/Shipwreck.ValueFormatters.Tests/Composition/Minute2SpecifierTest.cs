namespace Shipwreck.ValueFormatters.Composition;

public class Minute2SpecifierTest
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
            => new DateTime(2000, 1, 1, 0, n, 45);

        Assert.Equal(expected, new Minute2Specifier().Format(create(n)));
    }
}
