using System.IO;

namespace Shipwreck.ValueFormatters;

public static class TextWriterHelper
{
    public static void WriteTwoDigit(this TextWriter writer, int d)
    {
        if (d < 10)
        {
            writer.Write('0');
        }
        writer.Write(d);
    }

    public static void WriteThreeDigit(this TextWriter writer, int d)
    {
        if (d < 10)
        {
            writer.Write('0');
        }
        writer.WriteTwoDigit(d);
    }

    public static void WriteFourDigit(this TextWriter writer, int d)
    {
        if (d < 10)
        {
            writer.Write('0');
        }
        writer.WriteThreeDigit(d);
    }

    public static void WriteFiveDigit(this TextWriter writer, int d)
    {
        if (d < 10)
        {
            writer.Write('0');
        }
        writer.WriteFourDigit(d);
    }
}