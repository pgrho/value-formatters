namespace Shipwreck.ValueFormatters;

public interface IFormatParserConfiguration
{
    bool SupportsSemicolon { get; }

    bool IsSpecifier(char c);

    bool CanAppendSpecifier(StringBuilder token, char c);
}
