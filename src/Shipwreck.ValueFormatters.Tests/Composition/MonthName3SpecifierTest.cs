using System.Globalization;

namespace Shipwreck.ValueFormatters.Composition;

public class MonthName3SpecifierTest
{
    [Theory]
    [InlineData(1, "Jan")]
    [InlineData(9, "Sep")]
    [InlineData(10, "Oct")]
    [InlineData(11, "Nov")]
    [InlineData(12, "Dec")]
    public void Test(int n, string expected)
    {
        static DateTime create(int n)
            => new DateTime(2000, n, 1);

        Assert.Equal(expected, new MonthName3Specifier().Format(create(n), CultureInfo.InvariantCulture));
    }
}
