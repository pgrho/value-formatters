namespace Shipwreck.ValueFormatters;

internal static class CharsetFlagsExtensions
{
    public static CharsetFlags ToCharsetFlags(this char c)
        => c switch
        {
            '0' => CharsetFlags.Fallback0,
            '1' => CharsetFlags.Fallback1,
            '2' => CharsetFlags.Fallback2,
            '3' => CharsetFlags.Fallback3,
            '4' => CharsetFlags.Fallback4,
            '5' => CharsetFlags.Fallback5,
            '6' => CharsetFlags.Fallback6,
            '7' => CharsetFlags.Fallback7,
            '8' => CharsetFlags.Fallback8,
            '9' => CharsetFlags.Fallback9,
            'j' => CharsetFlags.Fallback10,
            'h' => CharsetFlags.Fallback100,
            's' => CharsetFlags.Fallback1000,
            'm' => CharsetFlags.Fallback10000,
            'o' => CharsetFlags.Fallback100000000,
            _ => CharsetFlags.Standard
        };

    public static CharsetFlags ToCharsetFlagsLessThan(this char c)
        => c switch
        {
            '0' => CharsetFlags.Standard,
            '1' => CharsetFlags.Fallback0,
            '2' => CharsetFlags.Fallback0to1,
            '3' => CharsetFlags.Fallback0to2,
            '4' => CharsetFlags.Fallback0to3,
            '5' => CharsetFlags.Fallback0to4,
            '6' => CharsetFlags.Fallback0to5,
            '7' => CharsetFlags.Fallback0to6,
            '8' => CharsetFlags.Fallback0to7,
            '9' => CharsetFlags.Fallback0to8,
            'j' => CharsetFlags.Fallback0to9,
            'h' => CharsetFlags.Fallback0to10,
            's' => CharsetFlags.Fallback0to100,
            'm' => CharsetFlags.Fallback0to1000,
            'o' => CharsetFlags.Fallback0to10000,
            _ => CharsetFlags.Standard
        };

    public static CharsetFlags ToCharsetFlagsGreaterThan(this char c)
        => ToCharsetFlagsLessThan(c) is var lt && lt != default
        ? CharsetFlags.FallbackAll & ~(ToCharsetFlags(c) | lt) : default;
}
