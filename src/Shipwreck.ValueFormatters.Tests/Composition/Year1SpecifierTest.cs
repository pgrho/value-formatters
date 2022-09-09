namespace Shipwreck.ValueFormatters.Composition;

public class Year1SpecifierTest
{
    [Theory]
    [InlineData(1, "1")]
    [InlineData(9, "9")]
    [InlineData(10, "10")]
    [InlineData(99, "99")]
    [InlineData(100, "0")]
    [InlineData(101, "1")]
    public void Test(int n, string expected)
    {
        static DateTime create(int n)
            => new DateTime(n, 1, 1);

        Assert.Equal(expected, new Year1Specifier().Format(create(n)));
    }
}
