namespace Shipwreck.ValueFormatters.Composition;

internal interface IBoolean
{
    bool Value { get; }
}

internal readonly struct BooleanTrue : IBoolean { public bool Value => true; }

internal readonly struct BooleanFalse : IBoolean { public bool Value => false; }