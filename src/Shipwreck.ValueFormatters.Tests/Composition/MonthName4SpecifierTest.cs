using System.Globalization;

namespace Shipwreck.ValueFormatters.Composition;

public class MonthName4SpecifierTest
{
    [Theory]
    [InlineData(1, "January")]
    [InlineData(9, "September")]
    [InlineData(10, "October")]
    [InlineData(11, "November")]
    [InlineData(12, "December")]
    public void Test(int n, string expected)
    {
        static DateTime create(int n)
            => new DateTime(2000, n, 1);

        Assert.Equal(expected, new MonthName4Specifier().Format(create(n), CultureInfo.InvariantCulture));
    }
}
