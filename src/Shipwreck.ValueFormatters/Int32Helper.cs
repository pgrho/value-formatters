namespace Shipwreck.ValueFormatters;

internal static class Int32Helper
{
    public static int ToBcdInt32(this int i)
    {
        if (i < 0 || 9999 < i)
        {
            throw new ArgumentOutOfRangeException(nameof(i));
        }

        i = Math.DivRem(i, 10, out var d3);
        i = Math.DivRem(i, 10, out var d2);
        i = Math.DivRem(i, 10, out var d1);
        Math.DivRem(i, 10, out var d0);

        return (d0 << 24) | (d1 << 16) | (d2 << 8) | d3;
    }

    public static long ToBcdInt64(this int i)
    {
        if (i < 0 || 99999999 < i)
        {
            throw new ArgumentOutOfRangeException(nameof(i));
        }

        i = Math.DivRem(i, 10000, out var u);

        return (((long)i.ToBcdInt32()) << 32) | (long)u.ToBcdInt32();
    }

    public static int Pow10(int y)
        => y switch
        {
            0 => 1,
            1 => 10,
            2 => 100,
            3 => 1000,
            4 => 10000,
            5 => 100000,
            6 => 1000000,
            7 => 10000000,
            8 => 100000000,
            9 => 1000000000,
            _ => throw new ArgumentOutOfRangeException()
        };
}
