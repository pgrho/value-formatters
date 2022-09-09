namespace Shipwreck.ValueFormatters.Composition;

public class Year5SpecifierTest
{
    [Theory]
    [InlineData(1, "00001")]
    [InlineData(9, "00009")]
    [InlineData(10, "00010")]
    [InlineData(99, "00099")]
    [InlineData(100, "00100")]
    [InlineData(101, "00101")]
    [InlineData(1000, "01000")]
    [InlineData(1001, "01001")]
    [InlineData(9999, "09999")]
    public void Test(int n, string expected)
    {
        static DateTime create(int n)
            => new DateTime(n, 1, 1);

        Assert.Equal(expected, new Year5Specifier().Format(create(n)));
    }
}