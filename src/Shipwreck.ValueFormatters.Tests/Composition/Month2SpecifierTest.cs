namespace Shipwreck.ValueFormatters.Composition;

public class Month2SpecifierTest
{
    [Theory]
    [InlineData(1, "01")]
    [InlineData(9, "09")]
    [InlineData(10, "10")]
    [InlineData(11, "11")]
    [InlineData(12, "12")]
    public void Test(int n, string expected)
    {
        static DateTime create(int n)
            => new DateTime(2000, n, 1);

        Assert.Equal(expected, new Month2Specifier().Format(create(n)));
    }
}
