namespace Shipwreck.ValueFormatters;

internal enum CharsetFlags
{
    Standard = 0,
    Japanese = 1 << 0,

    Fallback0 = Japanese << 1,
    Fallback1 = Fallback0 << 1,
    Fallback2 = Fallback1 << 1,
    Fallback3 = Fallback2 << 1,
    Fallback4 = Fallback3 << 1,
    Fallback5 = Fallback4 << 1,
    Fallback6 = Fallback5 << 1,
    Fallback7 = Fallback6 << 1,
    Fallback8 = Fallback7 << 1,
    Fallback9 = Fallback8 << 1,
    Fallback10 = Fallback9 << 1,
    Fallback100 = Fallback10 << 1,
    Fallback1000 = Fallback100 << 1,
    Fallback10000 = Fallback1000 << 1,
    Fallback100000000 = Fallback10000 << 1,

    Fallback0to1 = Fallback0 | Fallback1,
    Fallback0to2 = Fallback0to1 | Fallback2,
    Fallback0to3 = Fallback0to2 | Fallback3,
    Fallback0to4 = Fallback0to3 | Fallback4,
    Fallback0to5 = Fallback0to4 | Fallback5,
    Fallback0to6 = Fallback0to5 | Fallback6,
    Fallback0to7 = Fallback0to6 | Fallback7,
    Fallback0to8 = Fallback0to7 | Fallback8,
    Fallback0to9 = Fallback0to8 | Fallback9,
    Fallback0to10 = Fallback0to9 | Fallback10,
    Fallback0to100 = Fallback0to10 | Fallback100,
    Fallback0to1000 = Fallback0to100 | Fallback1000,
    Fallback0to10000 = Fallback0to1000 | Fallback10000,

    FallbackAll = Fallback0to10000 | Fallback0,
}
