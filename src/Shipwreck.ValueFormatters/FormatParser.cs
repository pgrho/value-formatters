using System.Collections.Generic;

namespace Shipwreck.ValueFormatters;

public class FormatParser
{
    public IEnumerable<(string token, FormatParserState type)> Parse<TConfig>(TConfig config, string format)
        where TConfig : IFormatParserConfiguration
    {
        var buf = new StringBuilder();
        var state = FormatParserState.Literal;

        for (var i = 0; i < format.Length; i++)
        {
            var c = format[i];
            if ((state & FormatParserState.BackSlash) == FormatParserState.BackSlash)
            {
                buf.Append(c);
                state &= ~FormatParserState.BackSlash;
            }
            else
            {
                switch (state)
                {
                    case FormatParserState.SingleQuote:
                        if (c == '\\')
                        {
                            state |= FormatParserState.BackSlash;
                        }
                        else if (c == '\'')
                        {
                            yield return (buf.ToString(), FormatParserState.Literal);
                            buf.Clear();
                            state = FormatParserState.Literal;
                        }
                        else
                        {
                            buf.Append(c);
                        }
                        break;

                    case FormatParserState.DoubleQuote:
                        if (c == '\\')
                        {
                            state |= FormatParserState.BackSlash;
                        }
                        else if (c == '"')
                        {
                            yield return (buf.ToString(), FormatParserState.Literal);
                            buf.Clear();
                            state = FormatParserState.Literal;
                        }
                        else
                        {
                            buf.Append(c);
                        }
                        break;

                    case FormatParserState.Specifier:
                        if (config.CanAppendSpecifier(buf, c))
                        {
                            buf.Append(c);
                        }
                        else
                        {
                            yield return (buf.ToString(), FormatParserState.Specifier);
                            buf.Clear();

                            if (c == '\\')
                            {
                                state = FormatParserState.Literal | FormatParserState.BackSlash;
                            }
                            else if (c == '\'')
                            {
                                state = FormatParserState.SingleQuote;
                            }
                            else if (c == '"')
                            {
                                state = FormatParserState.DoubleQuote;
                            }
                            else if (config.SupportsSemicolon && c == ';')
                            {
                                yield return (";", FormatParserState.Semicolon);
                                state = FormatParserState.Literal;
                            }
                            else
                            {
                                buf.Append(c);
                                state = config.IsSpecifier(c) ? FormatParserState.Specifier : FormatParserState.Literal;
                            }
                        }
                        break;

                    default:

                        if (c == '\\')
                        {
                            yield return (buf.ToString(), FormatParserState.Literal);
                            buf.Clear();
                            state = FormatParserState.Literal | FormatParserState.BackSlash;
                        }
                        else if (c == '\'')
                        {
                            yield return (buf.ToString(), FormatParserState.Literal);
                            buf.Clear();
                            state = FormatParserState.SingleQuote;
                        }
                        else if (c == '"')
                        {
                            yield return (buf.ToString(), FormatParserState.Literal);
                            buf.Clear();
                            state = FormatParserState.DoubleQuote;
                        }
                        else if (config.SupportsSemicolon && c == ';')
                        {
                            yield return (buf.ToString(), FormatParserState.Literal);
                            buf.Clear();
                            yield return (";", FormatParserState.Semicolon);
                            state = FormatParserState.Literal;
                        }
                        else if (config.IsSpecifier(c))
                        {
                            yield return (buf.ToString(), FormatParserState.Literal);
                            buf.Clear();
                            buf.Append(c);
                            state = FormatParserState.Specifier;
                        }
                        else
                        {
                            buf.Append(c);
                        }
                        break;
                }
            }
        }

        if (buf.Length > 0)
        {
            if (state == FormatParserState.Specifier)
            {
                yield return (buf.ToString(), FormatParserState.Specifier);
            }
            else
            {
                yield return (buf.ToString(), FormatParserState.Literal);
            }
        }
    }
}
