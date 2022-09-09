﻿namespace Shipwreck.ValueFormatters.Composition;

public partial struct Year2Specifier
{
    public byte MinimumLength => 2;
    public byte MaximumLength => 2;

    public int GetNumber(DateTime value) => value.Year % 100;
}
