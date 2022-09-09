using System.IO;

namespace Shipwreck.ValueFormatters.Composition;

internal sealed class CompositeFormatSpecifier<TValue
    , TSpecifier1
    , TSpecifier2
> : IFormatSpecifier<TValue>
    where TSpecifier1 : struct, IStructFormatSpecifier<TValue>
    where TSpecifier2 : struct, IStructFormatSpecifier<TValue>
{

    public void WriteTo(TextWriter writer, TValue value, IFormatProvider formatProvider)
    {
        default(TSpecifier1).WriteTo(writer, value, formatProvider);
        default(TSpecifier2).WriteTo(writer, value, formatProvider);
    }
    public bool TryFormat(Span<char> destination, out int charsWritten, TValue value, IFormatProvider formatProvider)
    {
        var rem = destination;
        charsWritten = 0;
        
        {
            if (!default(TSpecifier1).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }
        {
            if (!default(TSpecifier2).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }

        return true;
    }
}
internal sealed class CompositeFormatSpecifier<TValue
    , TSpecifier1
    , TSpecifier2
    , TSpecifier3
> : IFormatSpecifier<TValue>
    where TSpecifier1 : struct, IStructFormatSpecifier<TValue>
    where TSpecifier2 : struct, IStructFormatSpecifier<TValue>
    where TSpecifier3 : struct, IStructFormatSpecifier<TValue>
{

    public void WriteTo(TextWriter writer, TValue value, IFormatProvider formatProvider)
    {
        default(TSpecifier1).WriteTo(writer, value, formatProvider);
        default(TSpecifier2).WriteTo(writer, value, formatProvider);
        default(TSpecifier3).WriteTo(writer, value, formatProvider);
    }
    public bool TryFormat(Span<char> destination, out int charsWritten, TValue value, IFormatProvider formatProvider)
    {
        var rem = destination;
        charsWritten = 0;
        
        {
            if (!default(TSpecifier1).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }
        {
            if (!default(TSpecifier2).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }
        {
            if (!default(TSpecifier3).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }

        return true;
    }
}
internal sealed class CompositeFormatSpecifier<TValue
    , TSpecifier1
    , TSpecifier2
    , TSpecifier3
    , TSpecifier4
> : IFormatSpecifier<TValue>
    where TSpecifier1 : struct, IStructFormatSpecifier<TValue>
    where TSpecifier2 : struct, IStructFormatSpecifier<TValue>
    where TSpecifier3 : struct, IStructFormatSpecifier<TValue>
    where TSpecifier4 : struct, IStructFormatSpecifier<TValue>
{

    public void WriteTo(TextWriter writer, TValue value, IFormatProvider formatProvider)
    {
        default(TSpecifier1).WriteTo(writer, value, formatProvider);
        default(TSpecifier2).WriteTo(writer, value, formatProvider);
        default(TSpecifier3).WriteTo(writer, value, formatProvider);
        default(TSpecifier4).WriteTo(writer, value, formatProvider);
    }
    public bool TryFormat(Span<char> destination, out int charsWritten, TValue value, IFormatProvider formatProvider)
    {
        var rem = destination;
        charsWritten = 0;
        
        {
            if (!default(TSpecifier1).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }
        {
            if (!default(TSpecifier2).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }
        {
            if (!default(TSpecifier3).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }
        {
            if (!default(TSpecifier4).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }

        return true;
    }
}
internal sealed class CompositeFormatSpecifier<TValue
    , TSpecifier1
    , TSpecifier2
    , TSpecifier3
    , TSpecifier4
    , TSpecifier5
> : IFormatSpecifier<TValue>
    where TSpecifier1 : struct, IStructFormatSpecifier<TValue>
    where TSpecifier2 : struct, IStructFormatSpecifier<TValue>
    where TSpecifier3 : struct, IStructFormatSpecifier<TValue>
    where TSpecifier4 : struct, IStructFormatSpecifier<TValue>
    where TSpecifier5 : struct, IStructFormatSpecifier<TValue>
{

    public void WriteTo(TextWriter writer, TValue value, IFormatProvider formatProvider)
    {
        default(TSpecifier1).WriteTo(writer, value, formatProvider);
        default(TSpecifier2).WriteTo(writer, value, formatProvider);
        default(TSpecifier3).WriteTo(writer, value, formatProvider);
        default(TSpecifier4).WriteTo(writer, value, formatProvider);
        default(TSpecifier5).WriteTo(writer, value, formatProvider);
    }
    public bool TryFormat(Span<char> destination, out int charsWritten, TValue value, IFormatProvider formatProvider)
    {
        var rem = destination;
        charsWritten = 0;
        
        {
            if (!default(TSpecifier1).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }
        {
            if (!default(TSpecifier2).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }
        {
            if (!default(TSpecifier3).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }
        {
            if (!default(TSpecifier4).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }
        {
            if (!default(TSpecifier5).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }

        return true;
    }
}
internal sealed class CompositeFormatSpecifier<TValue
    , TSpecifier1
    , TSpecifier2
    , TSpecifier3
    , TSpecifier4
    , TSpecifier5
    , TSpecifier6
> : IFormatSpecifier<TValue>
    where TSpecifier1 : struct, IStructFormatSpecifier<TValue>
    where TSpecifier2 : struct, IStructFormatSpecifier<TValue>
    where TSpecifier3 : struct, IStructFormatSpecifier<TValue>
    where TSpecifier4 : struct, IStructFormatSpecifier<TValue>
    where TSpecifier5 : struct, IStructFormatSpecifier<TValue>
    where TSpecifier6 : struct, IStructFormatSpecifier<TValue>
{

    public void WriteTo(TextWriter writer, TValue value, IFormatProvider formatProvider)
    {
        default(TSpecifier1).WriteTo(writer, value, formatProvider);
        default(TSpecifier2).WriteTo(writer, value, formatProvider);
        default(TSpecifier3).WriteTo(writer, value, formatProvider);
        default(TSpecifier4).WriteTo(writer, value, formatProvider);
        default(TSpecifier5).WriteTo(writer, value, formatProvider);
        default(TSpecifier6).WriteTo(writer, value, formatProvider);
    }
    public bool TryFormat(Span<char> destination, out int charsWritten, TValue value, IFormatProvider formatProvider)
    {
        var rem = destination;
        charsWritten = 0;
        
        {
            if (!default(TSpecifier1).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }
        {
            if (!default(TSpecifier2).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }
        {
            if (!default(TSpecifier3).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }
        {
            if (!default(TSpecifier4).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }
        {
            if (!default(TSpecifier5).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }
        {
            if (!default(TSpecifier6).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }

        return true;
    }
}
internal sealed class CompositeFormatSpecifier<TValue
    , TSpecifier1
    , TSpecifier2
    , TSpecifier3
    , TSpecifier4
    , TSpecifier5
    , TSpecifier6
    , TSpecifier7
> : IFormatSpecifier<TValue>
    where TSpecifier1 : struct, IStructFormatSpecifier<TValue>
    where TSpecifier2 : struct, IStructFormatSpecifier<TValue>
    where TSpecifier3 : struct, IStructFormatSpecifier<TValue>
    where TSpecifier4 : struct, IStructFormatSpecifier<TValue>
    where TSpecifier5 : struct, IStructFormatSpecifier<TValue>
    where TSpecifier6 : struct, IStructFormatSpecifier<TValue>
    where TSpecifier7 : struct, IStructFormatSpecifier<TValue>
{

    public void WriteTo(TextWriter writer, TValue value, IFormatProvider formatProvider)
    {
        default(TSpecifier1).WriteTo(writer, value, formatProvider);
        default(TSpecifier2).WriteTo(writer, value, formatProvider);
        default(TSpecifier3).WriteTo(writer, value, formatProvider);
        default(TSpecifier4).WriteTo(writer, value, formatProvider);
        default(TSpecifier5).WriteTo(writer, value, formatProvider);
        default(TSpecifier6).WriteTo(writer, value, formatProvider);
        default(TSpecifier7).WriteTo(writer, value, formatProvider);
    }
    public bool TryFormat(Span<char> destination, out int charsWritten, TValue value, IFormatProvider formatProvider)
    {
        var rem = destination;
        charsWritten = 0;
        
        {
            if (!default(TSpecifier1).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }
        {
            if (!default(TSpecifier2).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }
        {
            if (!default(TSpecifier3).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }
        {
            if (!default(TSpecifier4).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }
        {
            if (!default(TSpecifier5).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }
        {
            if (!default(TSpecifier6).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }
        {
            if (!default(TSpecifier7).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }

        return true;
    }
}
internal sealed class CompositeFormatSpecifier<TValue
    , TSpecifier1
    , TSpecifier2
    , TSpecifier3
    , TSpecifier4
    , TSpecifier5
    , TSpecifier6
    , TSpecifier7
    , TSpecifier8
> : IFormatSpecifier<TValue>
    where TSpecifier1 : struct, IStructFormatSpecifier<TValue>
    where TSpecifier2 : struct, IStructFormatSpecifier<TValue>
    where TSpecifier3 : struct, IStructFormatSpecifier<TValue>
    where TSpecifier4 : struct, IStructFormatSpecifier<TValue>
    where TSpecifier5 : struct, IStructFormatSpecifier<TValue>
    where TSpecifier6 : struct, IStructFormatSpecifier<TValue>
    where TSpecifier7 : struct, IStructFormatSpecifier<TValue>
    where TSpecifier8 : struct, IStructFormatSpecifier<TValue>
{

    public void WriteTo(TextWriter writer, TValue value, IFormatProvider formatProvider)
    {
        default(TSpecifier1).WriteTo(writer, value, formatProvider);
        default(TSpecifier2).WriteTo(writer, value, formatProvider);
        default(TSpecifier3).WriteTo(writer, value, formatProvider);
        default(TSpecifier4).WriteTo(writer, value, formatProvider);
        default(TSpecifier5).WriteTo(writer, value, formatProvider);
        default(TSpecifier6).WriteTo(writer, value, formatProvider);
        default(TSpecifier7).WriteTo(writer, value, formatProvider);
        default(TSpecifier8).WriteTo(writer, value, formatProvider);
    }
    public bool TryFormat(Span<char> destination, out int charsWritten, TValue value, IFormatProvider formatProvider)
    {
        var rem = destination;
        charsWritten = 0;
        
        {
            if (!default(TSpecifier1).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }
        {
            if (!default(TSpecifier2).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }
        {
            if (!default(TSpecifier3).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }
        {
            if (!default(TSpecifier4).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }
        {
            if (!default(TSpecifier5).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }
        {
            if (!default(TSpecifier6).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }
        {
            if (!default(TSpecifier7).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }
        {
            if (!default(TSpecifier8).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }

        return true;
    }
}
internal sealed class CompositeFormatSpecifier<TValue
    , TSpecifier1
    , TSpecifier2
    , TSpecifier3
    , TSpecifier4
    , TSpecifier5
    , TSpecifier6
    , TSpecifier7
    , TSpecifier8
    , TSpecifier9
> : IFormatSpecifier<TValue>
    where TSpecifier1 : struct, IStructFormatSpecifier<TValue>
    where TSpecifier2 : struct, IStructFormatSpecifier<TValue>
    where TSpecifier3 : struct, IStructFormatSpecifier<TValue>
    where TSpecifier4 : struct, IStructFormatSpecifier<TValue>
    where TSpecifier5 : struct, IStructFormatSpecifier<TValue>
    where TSpecifier6 : struct, IStructFormatSpecifier<TValue>
    where TSpecifier7 : struct, IStructFormatSpecifier<TValue>
    where TSpecifier8 : struct, IStructFormatSpecifier<TValue>
    where TSpecifier9 : struct, IStructFormatSpecifier<TValue>
{

    public void WriteTo(TextWriter writer, TValue value, IFormatProvider formatProvider)
    {
        default(TSpecifier1).WriteTo(writer, value, formatProvider);
        default(TSpecifier2).WriteTo(writer, value, formatProvider);
        default(TSpecifier3).WriteTo(writer, value, formatProvider);
        default(TSpecifier4).WriteTo(writer, value, formatProvider);
        default(TSpecifier5).WriteTo(writer, value, formatProvider);
        default(TSpecifier6).WriteTo(writer, value, formatProvider);
        default(TSpecifier7).WriteTo(writer, value, formatProvider);
        default(TSpecifier8).WriteTo(writer, value, formatProvider);
        default(TSpecifier9).WriteTo(writer, value, formatProvider);
    }
    public bool TryFormat(Span<char> destination, out int charsWritten, TValue value, IFormatProvider formatProvider)
    {
        var rem = destination;
        charsWritten = 0;
        
        {
            if (!default(TSpecifier1).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }
        {
            if (!default(TSpecifier2).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }
        {
            if (!default(TSpecifier3).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }
        {
            if (!default(TSpecifier4).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }
        {
            if (!default(TSpecifier5).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }
        {
            if (!default(TSpecifier6).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }
        {
            if (!default(TSpecifier7).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }
        {
            if (!default(TSpecifier8).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }
        {
            if (!default(TSpecifier9).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }

        return true;
    }
}
internal sealed class CompositeFormatSpecifier<TValue
    , TSpecifier1
    , TSpecifier2
    , TSpecifier3
    , TSpecifier4
    , TSpecifier5
    , TSpecifier6
    , TSpecifier7
    , TSpecifier8
    , TSpecifier9
    , TSpecifier10
> : IFormatSpecifier<TValue>
    where TSpecifier1 : struct, IStructFormatSpecifier<TValue>
    where TSpecifier2 : struct, IStructFormatSpecifier<TValue>
    where TSpecifier3 : struct, IStructFormatSpecifier<TValue>
    where TSpecifier4 : struct, IStructFormatSpecifier<TValue>
    where TSpecifier5 : struct, IStructFormatSpecifier<TValue>
    where TSpecifier6 : struct, IStructFormatSpecifier<TValue>
    where TSpecifier7 : struct, IStructFormatSpecifier<TValue>
    where TSpecifier8 : struct, IStructFormatSpecifier<TValue>
    where TSpecifier9 : struct, IStructFormatSpecifier<TValue>
    where TSpecifier10 : struct, IStructFormatSpecifier<TValue>
{

    public void WriteTo(TextWriter writer, TValue value, IFormatProvider formatProvider)
    {
        default(TSpecifier1).WriteTo(writer, value, formatProvider);
        default(TSpecifier2).WriteTo(writer, value, formatProvider);
        default(TSpecifier3).WriteTo(writer, value, formatProvider);
        default(TSpecifier4).WriteTo(writer, value, formatProvider);
        default(TSpecifier5).WriteTo(writer, value, formatProvider);
        default(TSpecifier6).WriteTo(writer, value, formatProvider);
        default(TSpecifier7).WriteTo(writer, value, formatProvider);
        default(TSpecifier8).WriteTo(writer, value, formatProvider);
        default(TSpecifier9).WriteTo(writer, value, formatProvider);
        default(TSpecifier10).WriteTo(writer, value, formatProvider);
    }
    public bool TryFormat(Span<char> destination, out int charsWritten, TValue value, IFormatProvider formatProvider)
    {
        var rem = destination;
        charsWritten = 0;
        
        {
            if (!default(TSpecifier1).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }
        {
            if (!default(TSpecifier2).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }
        {
            if (!default(TSpecifier3).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }
        {
            if (!default(TSpecifier4).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }
        {
            if (!default(TSpecifier5).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }
        {
            if (!default(TSpecifier6).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }
        {
            if (!default(TSpecifier7).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }
        {
            if (!default(TSpecifier8).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }
        {
            if (!default(TSpecifier9).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }
        {
            if (!default(TSpecifier10).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }

        return true;
    }
}
internal sealed class CompositeFormatSpecifier<TValue
    , TSpecifier1
    , TSpecifier2
    , TSpecifier3
    , TSpecifier4
    , TSpecifier5
    , TSpecifier6
    , TSpecifier7
    , TSpecifier8
    , TSpecifier9
    , TSpecifier10
    , TSpecifier11
> : IFormatSpecifier<TValue>
    where TSpecifier1 : struct, IStructFormatSpecifier<TValue>
    where TSpecifier2 : struct, IStructFormatSpecifier<TValue>
    where TSpecifier3 : struct, IStructFormatSpecifier<TValue>
    where TSpecifier4 : struct, IStructFormatSpecifier<TValue>
    where TSpecifier5 : struct, IStructFormatSpecifier<TValue>
    where TSpecifier6 : struct, IStructFormatSpecifier<TValue>
    where TSpecifier7 : struct, IStructFormatSpecifier<TValue>
    where TSpecifier8 : struct, IStructFormatSpecifier<TValue>
    where TSpecifier9 : struct, IStructFormatSpecifier<TValue>
    where TSpecifier10 : struct, IStructFormatSpecifier<TValue>
    where TSpecifier11 : struct, IStructFormatSpecifier<TValue>
{

    public void WriteTo(TextWriter writer, TValue value, IFormatProvider formatProvider)
    {
        default(TSpecifier1).WriteTo(writer, value, formatProvider);
        default(TSpecifier2).WriteTo(writer, value, formatProvider);
        default(TSpecifier3).WriteTo(writer, value, formatProvider);
        default(TSpecifier4).WriteTo(writer, value, formatProvider);
        default(TSpecifier5).WriteTo(writer, value, formatProvider);
        default(TSpecifier6).WriteTo(writer, value, formatProvider);
        default(TSpecifier7).WriteTo(writer, value, formatProvider);
        default(TSpecifier8).WriteTo(writer, value, formatProvider);
        default(TSpecifier9).WriteTo(writer, value, formatProvider);
        default(TSpecifier10).WriteTo(writer, value, formatProvider);
        default(TSpecifier11).WriteTo(writer, value, formatProvider);
    }
    public bool TryFormat(Span<char> destination, out int charsWritten, TValue value, IFormatProvider formatProvider)
    {
        var rem = destination;
        charsWritten = 0;
        
        {
            if (!default(TSpecifier1).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }
        {
            if (!default(TSpecifier2).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }
        {
            if (!default(TSpecifier3).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }
        {
            if (!default(TSpecifier4).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }
        {
            if (!default(TSpecifier5).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }
        {
            if (!default(TSpecifier6).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }
        {
            if (!default(TSpecifier7).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }
        {
            if (!default(TSpecifier8).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }
        {
            if (!default(TSpecifier9).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }
        {
            if (!default(TSpecifier10).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }
        {
            if (!default(TSpecifier11).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }

        return true;
    }
}
internal sealed class CompositeFormatSpecifier<TValue
    , TSpecifier1
    , TSpecifier2
    , TSpecifier3
    , TSpecifier4
    , TSpecifier5
    , TSpecifier6
    , TSpecifier7
    , TSpecifier8
    , TSpecifier9
    , TSpecifier10
    , TSpecifier11
    , TSpecifier12
> : IFormatSpecifier<TValue>
    where TSpecifier1 : struct, IStructFormatSpecifier<TValue>
    where TSpecifier2 : struct, IStructFormatSpecifier<TValue>
    where TSpecifier3 : struct, IStructFormatSpecifier<TValue>
    where TSpecifier4 : struct, IStructFormatSpecifier<TValue>
    where TSpecifier5 : struct, IStructFormatSpecifier<TValue>
    where TSpecifier6 : struct, IStructFormatSpecifier<TValue>
    where TSpecifier7 : struct, IStructFormatSpecifier<TValue>
    where TSpecifier8 : struct, IStructFormatSpecifier<TValue>
    where TSpecifier9 : struct, IStructFormatSpecifier<TValue>
    where TSpecifier10 : struct, IStructFormatSpecifier<TValue>
    where TSpecifier11 : struct, IStructFormatSpecifier<TValue>
    where TSpecifier12 : struct, IStructFormatSpecifier<TValue>
{

    public void WriteTo(TextWriter writer, TValue value, IFormatProvider formatProvider)
    {
        default(TSpecifier1).WriteTo(writer, value, formatProvider);
        default(TSpecifier2).WriteTo(writer, value, formatProvider);
        default(TSpecifier3).WriteTo(writer, value, formatProvider);
        default(TSpecifier4).WriteTo(writer, value, formatProvider);
        default(TSpecifier5).WriteTo(writer, value, formatProvider);
        default(TSpecifier6).WriteTo(writer, value, formatProvider);
        default(TSpecifier7).WriteTo(writer, value, formatProvider);
        default(TSpecifier8).WriteTo(writer, value, formatProvider);
        default(TSpecifier9).WriteTo(writer, value, formatProvider);
        default(TSpecifier10).WriteTo(writer, value, formatProvider);
        default(TSpecifier11).WriteTo(writer, value, formatProvider);
        default(TSpecifier12).WriteTo(writer, value, formatProvider);
    }
    public bool TryFormat(Span<char> destination, out int charsWritten, TValue value, IFormatProvider formatProvider)
    {
        var rem = destination;
        charsWritten = 0;
        
        {
            if (!default(TSpecifier1).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }
        {
            if (!default(TSpecifier2).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }
        {
            if (!default(TSpecifier3).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }
        {
            if (!default(TSpecifier4).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }
        {
            if (!default(TSpecifier5).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }
        {
            if (!default(TSpecifier6).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }
        {
            if (!default(TSpecifier7).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }
        {
            if (!default(TSpecifier8).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }
        {
            if (!default(TSpecifier9).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }
        {
            if (!default(TSpecifier10).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }
        {
            if (!default(TSpecifier11).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }
        {
            if (!default(TSpecifier12).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }

        return true;
    }
}
internal sealed class CompositeFormatSpecifier<TValue
    , TSpecifier1
    , TSpecifier2
    , TSpecifier3
    , TSpecifier4
    , TSpecifier5
    , TSpecifier6
    , TSpecifier7
    , TSpecifier8
    , TSpecifier9
    , TSpecifier10
    , TSpecifier11
    , TSpecifier12
    , TSpecifier13
> : IFormatSpecifier<TValue>
    where TSpecifier1 : struct, IStructFormatSpecifier<TValue>
    where TSpecifier2 : struct, IStructFormatSpecifier<TValue>
    where TSpecifier3 : struct, IStructFormatSpecifier<TValue>
    where TSpecifier4 : struct, IStructFormatSpecifier<TValue>
    where TSpecifier5 : struct, IStructFormatSpecifier<TValue>
    where TSpecifier6 : struct, IStructFormatSpecifier<TValue>
    where TSpecifier7 : struct, IStructFormatSpecifier<TValue>
    where TSpecifier8 : struct, IStructFormatSpecifier<TValue>
    where TSpecifier9 : struct, IStructFormatSpecifier<TValue>
    where TSpecifier10 : struct, IStructFormatSpecifier<TValue>
    where TSpecifier11 : struct, IStructFormatSpecifier<TValue>
    where TSpecifier12 : struct, IStructFormatSpecifier<TValue>
    where TSpecifier13 : struct, IStructFormatSpecifier<TValue>
{

    public void WriteTo(TextWriter writer, TValue value, IFormatProvider formatProvider)
    {
        default(TSpecifier1).WriteTo(writer, value, formatProvider);
        default(TSpecifier2).WriteTo(writer, value, formatProvider);
        default(TSpecifier3).WriteTo(writer, value, formatProvider);
        default(TSpecifier4).WriteTo(writer, value, formatProvider);
        default(TSpecifier5).WriteTo(writer, value, formatProvider);
        default(TSpecifier6).WriteTo(writer, value, formatProvider);
        default(TSpecifier7).WriteTo(writer, value, formatProvider);
        default(TSpecifier8).WriteTo(writer, value, formatProvider);
        default(TSpecifier9).WriteTo(writer, value, formatProvider);
        default(TSpecifier10).WriteTo(writer, value, formatProvider);
        default(TSpecifier11).WriteTo(writer, value, formatProvider);
        default(TSpecifier12).WriteTo(writer, value, formatProvider);
        default(TSpecifier13).WriteTo(writer, value, formatProvider);
    }
    public bool TryFormat(Span<char> destination, out int charsWritten, TValue value, IFormatProvider formatProvider)
    {
        var rem = destination;
        charsWritten = 0;
        
        {
            if (!default(TSpecifier1).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }
        {
            if (!default(TSpecifier2).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }
        {
            if (!default(TSpecifier3).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }
        {
            if (!default(TSpecifier4).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }
        {
            if (!default(TSpecifier5).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }
        {
            if (!default(TSpecifier6).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }
        {
            if (!default(TSpecifier7).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }
        {
            if (!default(TSpecifier8).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }
        {
            if (!default(TSpecifier9).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }
        {
            if (!default(TSpecifier10).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }
        {
            if (!default(TSpecifier11).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }
        {
            if (!default(TSpecifier12).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }
        {
            if (!default(TSpecifier13).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }

        return true;
    }
}
internal sealed class CompositeFormatSpecifier<TValue
    , TSpecifier1
    , TSpecifier2
    , TSpecifier3
    , TSpecifier4
    , TSpecifier5
    , TSpecifier6
    , TSpecifier7
    , TSpecifier8
    , TSpecifier9
    , TSpecifier10
    , TSpecifier11
    , TSpecifier12
    , TSpecifier13
    , TSpecifier14
> : IFormatSpecifier<TValue>
    where TSpecifier1 : struct, IStructFormatSpecifier<TValue>
    where TSpecifier2 : struct, IStructFormatSpecifier<TValue>
    where TSpecifier3 : struct, IStructFormatSpecifier<TValue>
    where TSpecifier4 : struct, IStructFormatSpecifier<TValue>
    where TSpecifier5 : struct, IStructFormatSpecifier<TValue>
    where TSpecifier6 : struct, IStructFormatSpecifier<TValue>
    where TSpecifier7 : struct, IStructFormatSpecifier<TValue>
    where TSpecifier8 : struct, IStructFormatSpecifier<TValue>
    where TSpecifier9 : struct, IStructFormatSpecifier<TValue>
    where TSpecifier10 : struct, IStructFormatSpecifier<TValue>
    where TSpecifier11 : struct, IStructFormatSpecifier<TValue>
    where TSpecifier12 : struct, IStructFormatSpecifier<TValue>
    where TSpecifier13 : struct, IStructFormatSpecifier<TValue>
    where TSpecifier14 : struct, IStructFormatSpecifier<TValue>
{

    public void WriteTo(TextWriter writer, TValue value, IFormatProvider formatProvider)
    {
        default(TSpecifier1).WriteTo(writer, value, formatProvider);
        default(TSpecifier2).WriteTo(writer, value, formatProvider);
        default(TSpecifier3).WriteTo(writer, value, formatProvider);
        default(TSpecifier4).WriteTo(writer, value, formatProvider);
        default(TSpecifier5).WriteTo(writer, value, formatProvider);
        default(TSpecifier6).WriteTo(writer, value, formatProvider);
        default(TSpecifier7).WriteTo(writer, value, formatProvider);
        default(TSpecifier8).WriteTo(writer, value, formatProvider);
        default(TSpecifier9).WriteTo(writer, value, formatProvider);
        default(TSpecifier10).WriteTo(writer, value, formatProvider);
        default(TSpecifier11).WriteTo(writer, value, formatProvider);
        default(TSpecifier12).WriteTo(writer, value, formatProvider);
        default(TSpecifier13).WriteTo(writer, value, formatProvider);
        default(TSpecifier14).WriteTo(writer, value, formatProvider);
    }
    public bool TryFormat(Span<char> destination, out int charsWritten, TValue value, IFormatProvider formatProvider)
    {
        var rem = destination;
        charsWritten = 0;
        
        {
            if (!default(TSpecifier1).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }
        {
            if (!default(TSpecifier2).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }
        {
            if (!default(TSpecifier3).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }
        {
            if (!default(TSpecifier4).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }
        {
            if (!default(TSpecifier5).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }
        {
            if (!default(TSpecifier6).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }
        {
            if (!default(TSpecifier7).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }
        {
            if (!default(TSpecifier8).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }
        {
            if (!default(TSpecifier9).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }
        {
            if (!default(TSpecifier10).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }
        {
            if (!default(TSpecifier11).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }
        {
            if (!default(TSpecifier12).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }
        {
            if (!default(TSpecifier13).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }
        {
            if (!default(TSpecifier14).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }

        return true;
    }
}
internal sealed class CompositeFormatSpecifier<TValue
    , TSpecifier1
    , TSpecifier2
    , TSpecifier3
    , TSpecifier4
    , TSpecifier5
    , TSpecifier6
    , TSpecifier7
    , TSpecifier8
    , TSpecifier9
    , TSpecifier10
    , TSpecifier11
    , TSpecifier12
    , TSpecifier13
    , TSpecifier14
    , TSpecifier15
> : IFormatSpecifier<TValue>
    where TSpecifier1 : struct, IStructFormatSpecifier<TValue>
    where TSpecifier2 : struct, IStructFormatSpecifier<TValue>
    where TSpecifier3 : struct, IStructFormatSpecifier<TValue>
    where TSpecifier4 : struct, IStructFormatSpecifier<TValue>
    where TSpecifier5 : struct, IStructFormatSpecifier<TValue>
    where TSpecifier6 : struct, IStructFormatSpecifier<TValue>
    where TSpecifier7 : struct, IStructFormatSpecifier<TValue>
    where TSpecifier8 : struct, IStructFormatSpecifier<TValue>
    where TSpecifier9 : struct, IStructFormatSpecifier<TValue>
    where TSpecifier10 : struct, IStructFormatSpecifier<TValue>
    where TSpecifier11 : struct, IStructFormatSpecifier<TValue>
    where TSpecifier12 : struct, IStructFormatSpecifier<TValue>
    where TSpecifier13 : struct, IStructFormatSpecifier<TValue>
    where TSpecifier14 : struct, IStructFormatSpecifier<TValue>
    where TSpecifier15 : struct, IStructFormatSpecifier<TValue>
{

    public void WriteTo(TextWriter writer, TValue value, IFormatProvider formatProvider)
    {
        default(TSpecifier1).WriteTo(writer, value, formatProvider);
        default(TSpecifier2).WriteTo(writer, value, formatProvider);
        default(TSpecifier3).WriteTo(writer, value, formatProvider);
        default(TSpecifier4).WriteTo(writer, value, formatProvider);
        default(TSpecifier5).WriteTo(writer, value, formatProvider);
        default(TSpecifier6).WriteTo(writer, value, formatProvider);
        default(TSpecifier7).WriteTo(writer, value, formatProvider);
        default(TSpecifier8).WriteTo(writer, value, formatProvider);
        default(TSpecifier9).WriteTo(writer, value, formatProvider);
        default(TSpecifier10).WriteTo(writer, value, formatProvider);
        default(TSpecifier11).WriteTo(writer, value, formatProvider);
        default(TSpecifier12).WriteTo(writer, value, formatProvider);
        default(TSpecifier13).WriteTo(writer, value, formatProvider);
        default(TSpecifier14).WriteTo(writer, value, formatProvider);
        default(TSpecifier15).WriteTo(writer, value, formatProvider);
    }
    public bool TryFormat(Span<char> destination, out int charsWritten, TValue value, IFormatProvider formatProvider)
    {
        var rem = destination;
        charsWritten = 0;
        
        {
            if (!default(TSpecifier1).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }
        {
            if (!default(TSpecifier2).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }
        {
            if (!default(TSpecifier3).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }
        {
            if (!default(TSpecifier4).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }
        {
            if (!default(TSpecifier5).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }
        {
            if (!default(TSpecifier6).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }
        {
            if (!default(TSpecifier7).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }
        {
            if (!default(TSpecifier8).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }
        {
            if (!default(TSpecifier9).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }
        {
            if (!default(TSpecifier10).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }
        {
            if (!default(TSpecifier11).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }
        {
            if (!default(TSpecifier12).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }
        {
            if (!default(TSpecifier13).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }
        {
            if (!default(TSpecifier14).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }
        {
            if (!default(TSpecifier15).TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }

        return true;
    }
}


