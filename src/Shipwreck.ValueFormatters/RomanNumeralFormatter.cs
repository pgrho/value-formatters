using System.IO;

namespace Shipwreck.ValueFormatters;

public sealed class RomanNumeralFormatter : Int32ValueFormatter
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
        if (!TryParseFormat(value, format, out var isUpperCase, out var isAddition))
        {
            throw new ArgumentException();
        }
        WriteTo(writer, value, isUpperCase, isAddition);
    } 

    private static bool TryParseFormat(int value, ReadOnlySpan<char> format, out bool isUpperCase, out bool isAddition)
    {
        if (0 < value && value < 4000)
        {
            switch (format.Length)
            {
                case 1:
                    switch (format[0])
                    {
                        case 'L':
                        case 'l':
                            isUpperCase = format[0] == 'L';
                            isAddition = false;
                            return true;
                    }
                    break;

                case 2:
                    switch (format[0])
                    {
                        case 'L':
                        case 'l':
                            switch (format[1])
                            {
                                case 'A':
                                case 'a':
                                case 'S':
                                case 's':
                                    isUpperCase = format[0] == 'L';
                                    isAddition = format[1] == 'A' || format[1] == 'a';
                                    return true;
                            }
                            break;
                    }
                    break;
            }
        }

        isUpperCase = isAddition = false;
        return false;
    }

    static char GetNumeral(int n, bool isUpperCase)
        => (char)(n switch
        {
            1 => 'I',
            5 => 'V',
            10 => 'X',
            50 => 'L',
            100 => 'C',
            500 => 'D',
            1000 => 'M',
            _ => throw new ArgumentOutOfRangeException()
        } + (isUpperCase ? 0 : ('a' - 'A')));

    private static void WriteTo(TextWriter writer, int value, bool isUpperCase, bool isAddition)
    {
        for (var div = 1000; div > 0; div /= 10)
        {
            var en = Math.DivRem(value, div, out var mr);

            if (1 <= en && en <= 3 || en == 4 && isAddition)
            {
                var c = GetNumeral(div, isUpperCase);
                for (var i = 1; i <= en; i++)
                {
                    writer.Write(c);
                }
            }
            else if (en == 4 && !isAddition)
            {
                writer.Write(GetNumeral(div, isUpperCase));
                writer.Write(GetNumeral(div * 5, isUpperCase));
            }
            else if (5 <= en && en <= 8 || en == 9 && isAddition)
            {
                writer.Write(GetNumeral(div * 5, isUpperCase));
                var c = GetNumeral(div, isUpperCase);
                for (var i = 6; i <= en; i++)
                {
                    writer.Write(c);
                }
            }
            else if (en == 9 && !isAddition)
            {
                writer.Write(GetNumeral(div, isUpperCase));
                writer.Write(GetNumeral(div * 10, isUpperCase));
            }

            value = mr;
        }
    }
}
