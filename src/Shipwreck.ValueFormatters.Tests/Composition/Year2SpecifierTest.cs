namespace Shipwreck.ValueFormatters.Composition;

public class Year2SpecifierTest
{
    [Theory]
    [InlineData(1, "01")]
    [InlineData(9, "09")]
    [InlineData(10, "10")]
    [InlineData(99, "99")]
    [InlineData(100, "00")]
    [InlineData(101, "01")]
    public void Test(int n, string expected)
    {
        static DateTime create(int n)
            => new DateTime(n, 1, 1);

        Assert.Equal(expected, new Year2Specifier().Format(create(n)));
    }
}
