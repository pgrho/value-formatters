using System.Globalization;

namespace Shipwreck.ValueFormatters.Composition;

public class DayName3SpecifierTest
{
    [Theory]
    [InlineData(DayOfWeek.Sunday)]
    [InlineData(DayOfWeek.Monday)]
    [InlineData(DayOfWeek.Tuesday)]
    [InlineData(DayOfWeek.Wednesday)]
    [InlineData(DayOfWeek.Thursday)]
    [InlineData(DayOfWeek.Friday)]
    [InlineData(DayOfWeek.Saturday)]
    public void Test(DayOfWeek dayOfWeek)
    {
        static DateTime create(DayOfWeek n)
            => new DateTime(2000, 1, 2 + (int)n);

        Assert.Equal(dayOfWeek.ToString("G").Substring(0, 3), new DayName3Specifier().Format(create(dayOfWeek), CultureInfo.InvariantCulture));
    }
}
