namespace Shipwreck.ValueFormatters.Composition;

internal interface ICharLiteralSpecifier<T> : IStructFormatSpecifier<T>
{
    char Char { get; }
}
