namespace Shipwreck.ValueFormatters;

public class ChineseNumeralFormatterTest
{
    [Theory]
    [InlineData("cj", 0, "〇")]
    [InlineData("cj", 1, "一")]
    [InlineData("cj", 2, "二")]
    [InlineData("cj", 3, "三")]
    [InlineData("cj", 4, "四")]
    [InlineData("cj", 5, "五")]
    [InlineData("cj", 6, "六")]
    [InlineData("cj", 7, "七")]
    [InlineData("cj", 8, "八")]
    [InlineData("cj", 9, "九")]
    [InlineData("cj", 10, "十")]
    [InlineData("cj", 11, "十一")]
    [InlineData("cj", 21, "二十一")]
    [InlineData("cj", 100, "百")]
    [InlineData("cj", 101, "百一")]
    [InlineData("cj", 321, "三百二十一")]
    [InlineData("cj", 4321, "四千三百二十一")]
    [InlineData("cj", 10000, "一万")]
    [InlineData("cj", 43210000, "四千三百二十一万")]
    [InlineData("cj", 10000_0000, "一億")]
    [InlineData("cj", 21_0000_0000, "二十一億")]
    [InlineData("cj", 8765_4321, "八千七百六十五万四千三百二十一")]
    public void Test(string format, int value, string expected)
        => Assert.Equal(expected, new ChineseNumeralFormatter().ToString(value, format));
}
