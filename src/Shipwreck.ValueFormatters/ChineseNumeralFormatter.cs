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
        => TryParseFormat(value, format);

    public override void WriteTo(TextWriter writer, int value, ReadOnlySpan<char> format, IFormatProvider provider)
        => WriteTo(writer, value, format);

    public static void WriteTo(TextWriter writer, int value, string format)
        => WriteTo(writer, value, format.AsSpan());

    public static void WriteTo(TextWriter writer, int value, ReadOnlySpan<char> format)
    {
        if (!TryParseFormat(value, format))
        {
            throw new ArgumentException();
        }
        WriteTo(writer, value);
    }

    private static bool TryParseFormat(int value, ReadOnlySpan<char> format)
    {
        if (value < 0)
        {
            return false;
        }

        // TODO: (cj|jp|cn|tw)d?\d?
        return format.Length == 2 && format[0] == 'c' && format[1] == 'j';
    }

    static char GetNumeral(int n)
    {
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

    private static void WriteTo(TextWriter writer, int value)
    {
        if (value == 0)
        {
            writer.Write(GetNumeral(0));
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
                        writer.Write(GetNumeral(en2));
                    }

                    if (en2 > 0 && div2 > 1)
                    {
                        writer.Write(GetNumeral(div2));
                    }

                    en = mr2;
                }

                if (div > 1)
                {
                    writer.Write(GetNumeral(div));
                }
            }

            value = mr;
        }
    }
}
