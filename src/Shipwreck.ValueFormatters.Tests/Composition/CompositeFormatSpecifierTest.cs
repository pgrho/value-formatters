namespace Shipwreck.ValueFormatters.Composition;

public class CompositeFormatSpecifierTest
{
    [Fact]
    public void CreateTest_YM()
    {
        var y = new Year4Specifier();
        var m = new Month2Specifier();

        var result = CompositeFormatSpecifier.Create(new IFormatSpecifier<DateTime>[] { y, m });

        Assert.IsType<CompositeFormatSpecifier<DateTime, Year4Specifier, Month2Specifier>>(result);

        var dt = DateTime.Now;

        Assert.Equal(dt.ToString("yyyyMM"), result.Format(dt));
    }

    [Fact]
    public void CreateTest_YMD()
    {
        var y = new Year4Specifier();
        var m = new Month2Specifier();
        var d = new Day2Specifier();

        var result = CompositeFormatSpecifier.Create(new IFormatSpecifier<DateTime>[] { y, m, d });

        Assert.IsType<CompositeFormatSpecifier<DateTime, Year4Specifier, Month2Specifier, Day2Specifier>>(result);

        var dt = DateTime.Now;

        Assert.Equal(dt.ToString("yyyyMMdd"), result.Format(dt));
    }

    [Theory]
    [InlineData(2)]
    [InlineData(15)]
    [InlineData(16)]
    public void CreateTest(int n)
    {
        var types = Enumerable.Range(0, n).Select(
            i => (i % 6) switch
            {
                0 => typeof(Year2Specifier),
                1 => typeof(Month2Specifier),
                2 => typeof(Day2Specifier),
                3 => typeof(Hour2Specifier),
                4 => typeof(Minute2Specifier),
                5 or _ => typeof(Second2Specifier),
            })
            .ToList();
        var format = string.Concat(Enumerable.Range(0, n).Select(
            i => (i % 6) switch
            {
                0 => "yy",
                1 => "MM",
                2 => "dd",
                3 => "HH",
                4 => "mm",
                5 or _ => "ss",
            }));

        var result = CompositeFormatSpecifier.Create(types.Select(e => (IFormatSpecifier<DateTime>)Activator.CreateInstance(e)!));

        var dt = DateTime.Now;

        var ts = (366 * 2 + 31 * 3 + 1 * 5) * TimeSpan.TicksPerDay + 7 * TimeSpan.TicksPerHour + 11 * TimeSpan.TicksPerSecond + 13 * TimeSpan.TicksPerSecond;

        for (var i = 0; i < 10; i++)
        {
            Assert.Equal(dt.ToString(format), result.Format(dt));

            dt = dt.AddTicks(ts);
        }
    }
}
