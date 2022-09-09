namespace Shipwreck.ValueFormatters.Composition;

public class Second1SpecifierTest
{
    [Theory]
    [InlineData(0, "0")]
    [InlineData(1, "1")]
    [InlineData(9, "9")]
    [InlineData(10, "10")]
    [InlineData(59, "59")]
    public void Test(int n, string expected)
    {
        static DateTime create(int n)
            => new DateTime(2000, 1, 1, 0, 0, n);

        Assert.Equal(expected, new Second1Specifier().Format(create(n)));
    }
}
