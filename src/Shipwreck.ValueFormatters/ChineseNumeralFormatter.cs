using System.IO;

namespace Shipwreck.ValueFormatters;

public sealed class ChineseNumeralFormatter : Int32ValueFormatter
{
    public override bool Supports(int value, ReadOnlySpan<char> format, IFormatProvider provider)
        => Supports(value, format);

    public static bool Supports(int value, string format)
        => format != null
        && Supports(value, format.AsSpan());

    public static bool Supports(int value, ReadOnlySpan<char> format)
        => TryParseFormat(value, format, out var _, out var _);

    public override void WriteTo(TextWriter writer, int value, ReadOnlySpan<char> format, IFormatProvider provider)
        => WriteTo(writer, value, format);

    public static void WriteTo(TextWriter writer, int value, string format)
        => WriteTo(writer, value, format.AsSpan());

    public static void WriteTo(TextWriter writer, int value, ReadOnlySpan<char> format)
    {
        if (!TryParseFormat(value, format, out var charset, out var isDigitMode))
        {
            throw new ArgumentException();
        }
        if (isDigitMode)
        {
            WriteDigitsTo(writer, value, charset);
        }
        else
        {
            WriteTo(writer, value, charset);
        }
    }

    private static bool TryParseFormat(int value, ReadOnlySpan<char> format, out CharsetFlags charset, out bool isDigitMode)
    {
        // (cj|jp)d?([-+][0-9jhsmo])*
        // (cj|jp): base charset
        // d?: digitMode
        // [-+][0-9jhsmo]: disable or enable each alternative char
        if (value >= 0 && 2 <= format.Length)
        {
            isDigitMode = format.Length >= 3 && format[2] == 'd';

            if (format[0] == 'c' && format[1] == 'j')
            {
                charset = CharsetFlags.Standard;
            }
            else if (format[0] == 'j' && format[1] == 'p')
            {
                charset = CharsetFlags.Japanese;
            }
            else
            {
                charset = default;
                isDigitMode = false;
                return false;
            }

            for (var p = isDigitMode ? 3 : 2; p < format.Length; p += 2)
            {
                if (p + 2 > format.Length)
                {
                    return false;
                }

                switch (format[p])
                {
                    case '-':
                    case '+':

                        var cf = format[p + 1].ToCharsetFlags();
                        if (cf == default)
                        {
                            return false;
                        }

                        if (format[p] == '-')
                        {
                            charset |= cf;
                        }
                        else
                        {
                            charset &= ~cf;
                        }
                        break;

                    case '<':
                    case '>':
                        var rf = format[p] == '<' ? format[p + 1].ToCharsetFlagsLessThan() : format[p + 1].ToCharsetFlagsGreaterThan();
                        if (rf == default)
                        {
                            return false;
                        }
                        charset |= rf;
                        break;

                    default:
                        return false;
                }
            }
            return true;
        }

        charset = default;
        isDigitMode = false;

        return false;
    }

    static char GetNumeral(int n, CharsetFlags charset)
    {
        var substitute = ((n switch
        {
            0 => CharsetFlags.Fallback0,
            1 => CharsetFlags.Fallback1,
            2 => CharsetFlags.Fallback2,
            3 => CharsetFlags.Fallback3,
            4 => CharsetFlags.Fallback4,
            5 => CharsetFlags.Fallback5,
            6 => CharsetFlags.Fallback6,
            7 => CharsetFlags.Fallback7,
            8 => CharsetFlags.Fallback8,
            9 => CharsetFlags.Fallback9,
            10 => CharsetFlags.Fallback10,
            100 => CharsetFlags.Fallback100,
            1000 => CharsetFlags.Fallback1000,
            10000 => CharsetFlags.Fallback10000,
            100000000 => CharsetFlags.Fallback100000000,
            _ => default
        }) & charset) == 0;

        if ((charset & CharsetFlags.Japanese) != 0
            && substitute)
        {
            return n switch
            {
                0 => '零',
                1 => '壱',
                2 => '弐',
                3 => '参',
                4 => '肆',
                5 => '伍',
                6 => '陸',
                7 => '漆',
                8 => '捌',
                9 => '玖',
                10 => '拾',
                100 => '陌',
                1000 => '阡',
                10000 => '萬',
                100000000 => '億',
                _ => throw new ArgumentOutOfRangeException()
            };
        }
        return n switch
        {
            0 => '〇',
            1 => '一',
            2 => '二',
            3 => '三',
            4 => '四',
            5 => '五',
            6 => '六',
            7 => '七',
            8 => '八',
            9 => '九',
            10 => '十',
            100 => '百',
            1000 => '千',
            10000 => '万',
            100000000 => '億',
            _ => throw new ArgumentOutOfRangeException()
        };
    }

    private static void WriteTo(TextWriter writer, int value, CharsetFlags charset)
    {
        if (value == 0)
        {
            writer.Write(GetNumeral(0, charset));
            return;
        }
        for (var div = 10000_0000; div > 0; div /= 10000)
        {
            // 億/万/1

            var en = Math.DivRem(value, div, out var mr);

            if (en > 0)
            {
                for (var div2 = 1000; div2 > 0; div2 /= 10)
                {
                    var en2 = Math.DivRem(en, div2, out var mr2);

                    if (en2 > 1 || (en2 == 1 && div2 == 1))
                    {
                        writer.Write(GetNumeral(en2, charset));
                    }

                    if (en2 > 0 && div2 > 1)
                    {
                        writer.Write(GetNumeral(div2, charset));
                    }

                    en = mr2;
                }

                if (div > 1)
                {
                    writer.Write(GetNumeral(div, charset));
                }
            }

            value = mr;
        }
    }

    private static void WriteDigitsTo(TextWriter writer, int value, CharsetFlags charset)
    {
        if (value == 0)
        {
            writer.Write(GetNumeral(0, charset));
            return;
        }

        var first = true;
        for (var div = 10_0000_0000; div > 0; div /= 10)
        {
            var en = Math.DivRem(value, div, out var mr);

            if (en > 0 || !first)
            {
                writer.Write(GetNumeral(en, charset));
                first = false;
            }

            value = mr;
        }
    }
}
