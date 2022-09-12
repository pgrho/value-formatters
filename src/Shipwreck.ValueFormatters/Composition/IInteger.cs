using System.IO;

namespace Shipwreck.ValueFormatters.Composition;

internal interface IInteger
{
    int Value { get; }
}

internal struct Integer1 : IInteger { public int Value => 1; }

internal struct Integer2 : IInteger { public int Value => 2; }

internal struct Integer3 : IInteger { public int Value => 3; }

internal struct Integer4 : IInteger { public int Value => 4; }

internal struct Integer5 : IInteger { public int Value => 5; }

internal struct Integer6 : IInteger { public int Value => 6; }

internal struct Integer7 : IInteger { public int Value => 7; }
