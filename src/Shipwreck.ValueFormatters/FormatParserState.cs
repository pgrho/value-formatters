namespace Shipwreck.ValueFormatters;

[Flags]
public enum FormatParserState
{
    Literal = 1,
    Specifier = 2,
    SingleQuote = 3,
    DoubleQuote = 4,
    Semicolon = 5,
    BackSlash = 8,
}
