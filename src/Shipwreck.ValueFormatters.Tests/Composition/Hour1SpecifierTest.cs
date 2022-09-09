namespace Shipwreck.ValueFormatters.Composition;

public class Hour1SpecifierTest
{
    [Theory]
    [InlineData(0, "0")]
    [InlineData(1, "1")]
    [InlineData(9, "9")]
    [InlineData(10, "10")]
    [InlineData(23, "23")]
    public void Test(int n, string expected)
    {
        static DateTime create(int n)
            => new DateTime(2000, 1, 1, n, 12, 34);

        Assert.Equal(expected, new Hour1Specifier().Format(create(n)));
    }
}
