using System.IO;

namespace Shipwreck.ValueFormatters;

public sealed class RomanNumeralFormatter : Int32ValueFormatter
{
    public override bool Supports(int value, string format, IFormatProvider formatProvider)
        => Supports(value, format);

    public static bool Supports(int value, string format)
        => 1 <= value
        && value < 4000
        && format switch
        {
            "L" => true,
            "l" => true,
            "LA" => true,
            "la" => true,
            "LS" => true,
            "ls" => true,
            _ => false,
        };

    public override void WriteTo(TextWriter writer, int value, string format, IFormatProvider formatProvider)
        => WriteTo(writer, value, format);

    public static void WriteTo(TextWriter writer, int value, string format)
    {
        if (value <= 0 || 4000 <= value)
        {
            throw new ArgumentOutOfRangeException(nameof(value));
        }
        switch (format)
        {
            case "L":
            case "LS":
                WriteTo(writer, value, true, false);
                return;

            case "l":
            case "ls":
                WriteTo(writer, value, false, false);
                return;

            case "LA":
                WriteTo(writer, value, true, true);
                return;

            case "la":
                WriteTo(writer, value, false, true);
                return;
        }
        throw new NotSupportedException();
    }

    private static void WriteTo(TextWriter writer, int value, bool isUpperCase, bool isAddition)
    {
        static char getNumeral(int n)
            => n switch
            {
                1 => 'I',
                5 => 'V',
                10 => 'X',
                50 => 'L',
                100 => 'C',
                500 => 'D',
                1000 => 'M',
                _ => throw new ArgumentOutOfRangeException()
            };

        var offset = isUpperCase ? 0 : ('a' - 'A');
        for (var div = 1000; div > 0; div /= 10)
        {
            var en = Math.DivRem(value, div, out var mr);

            if (1 <= en && en <= 3 || (en == 4 && isAddition))
            {
                var c = (char)(getNumeral(div) + offset);
                for (var i = 1; i <= en; i++)
                {
                    writer.Write(c);
                }
            }
            else if (en == 4 && !isAddition)
            {
                writer.Write((char)(getNumeral(div) + offset));
                writer.Write((char)(getNumeral(div * 5) + offset));
            }
            else if (5 <= en && en <= 8 || (en == 9 && isAddition))
            {
                writer.Write((char)(getNumeral(div * 5) + offset));
                var c = (char)(getNumeral(div) + offset);
                for (var i = 6; i <= en; i++)
                {
                    writer.Write(c);
                }
            }
            else if (en == 9 && !isAddition)
            {
                writer.Write((char)(getNumeral(div) + offset));
                writer.Write((char)(getNumeral(div * 10) + offset));
            }

            value = mr;
        }
    }
}
