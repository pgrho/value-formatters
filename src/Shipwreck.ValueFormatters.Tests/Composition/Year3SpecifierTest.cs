namespace Shipwreck.ValueFormatters.Composition;

public class Year3SpecifierTest
{
    [Theory]
    [InlineData(1, "001")]
    [InlineData(9, "009")]
    [InlineData(10, "010")]
    [InlineData(99, "099")]
    [InlineData(100, "100")]
    [InlineData(101, "101")]
    [InlineData(1000, "1000")]
    [InlineData(1001, "1001")]
    [InlineData(9999, "9999")]
    public void Test(int n, string expected)
    {
        static DateTime create(int n)
            => new DateTime(n, 1, 1);

        Assert.Equal(expected, new Year3Specifier().Format(create(n)));
    }
}
