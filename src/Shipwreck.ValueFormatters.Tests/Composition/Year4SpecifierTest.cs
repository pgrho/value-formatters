namespace Shipwreck.ValueFormatters.Composition;

public class Year4SpecifierTest
{
    [Theory]
    [InlineData(1, "0001")]
    [InlineData(9, "0009")]
    [InlineData(10, "0010")]
    [InlineData(99, "0099")]
    [InlineData(100, "0100")]
    [InlineData(101, "0101")]
    [InlineData(1000, "1000")]
    [InlineData(1001, "1001")]
    [InlineData(9999, "9999")]
    public void Test(int n, string expected)
    {
        static DateTime create(int n)
            => new DateTime(n, 1, 1);

        Assert.Equal(expected, new Year4Specifier().Format(create(n)));
    }
}
