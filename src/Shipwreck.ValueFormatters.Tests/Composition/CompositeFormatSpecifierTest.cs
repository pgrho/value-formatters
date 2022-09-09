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
}
