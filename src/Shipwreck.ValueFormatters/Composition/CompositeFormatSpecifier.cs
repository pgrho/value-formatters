using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Shipwreck.ValueFormatters.Composition;

public static class CompositeFormatSpecifier
{
    public static IFormatSpecifier<T> Create<T>(IEnumerable<IFormatSpecifier<T>> specifiers)
    {
        var sl = new List<IFormatSpecifier<T>>();
        var structStartedAt = -1;

        void flushStructs()
        {
            var stypes = sl.Skip(structStartedAt).Select(e => e.GetType()).ToList();
            var td = stypes.Count switch
            {
                2 => typeof(CompositeFormatSpecifier<,,>),
                3 => typeof(CompositeFormatSpecifier<,,,>),
                4 => typeof(CompositeFormatSpecifier<,,,,>),
                5 => typeof(CompositeFormatSpecifier<,,,,,>),
                6 => typeof(CompositeFormatSpecifier<,,,,,,>),
                7 => typeof(CompositeFormatSpecifier<,,,,,,,>),
                8 => typeof(CompositeFormatSpecifier<,,,,,,,,>),
                9 => typeof(CompositeFormatSpecifier<,,,,,,,,,>),
                10 => typeof(CompositeFormatSpecifier<,,,,,,,,,,>),
                11 => typeof(CompositeFormatSpecifier<,,,,,,,,,,,>),
                12 => typeof(CompositeFormatSpecifier<,,,,,,,,,,,,>),
                13 => typeof(CompositeFormatSpecifier<,,,,,,,,,,,,,>),
                14 => typeof(CompositeFormatSpecifier<,,,,,,,,,,,,,,>),
                15 => typeof(CompositeFormatSpecifier<,,,,,,,,,,,,,,,>),
                _ => throw new ArgumentException()
            };

            stypes.Insert(0, typeof(T));

            var genType = td.MakeGenericType(stypes.ToArray());

            sl.RemoveRange(structStartedAt, stypes.Count - 1);
            sl.Add((IFormatSpecifier<T>)Activator.CreateInstance(genType));
        }

        foreach (var s in specifiers)
        {
            if (s is IStructFormatSpecifier<T>)
            {
                if (structStartedAt < 0)
                {
                    structStartedAt = sl.Count;
                }
                else if (structStartedAt + 15 <= sl.Count)
                {
                    flushStructs();
                    structStartedAt = sl.Count;
                }
                sl.Add(s);
            }
            else
            {
                if (structStartedAt >= 0 && structStartedAt + 1 < sl.Count)
                {
                    flushStructs();

                    structStartedAt = -1;
                }
                sl.Add(s);
            }
        }

        if (!sl.Any())
        {
            throw new ArgumentException();
        }

        if (structStartedAt >= 0 && structStartedAt + 1 < sl.Count)
        {
            flushStructs();
        }

        return sl.Count == 1 ? sl[0] : new CompositeFormatSpecifier<T>(sl.ToArray());
    }
}

public sealed class CompositeFormatSpecifier<T> : IFormatSpecifier<T>
{
    private readonly IFormatSpecifier<T>[] _Specifiers;

    public CompositeFormatSpecifier(IEnumerable<IFormatSpecifier<T>> specifiers)
    {
        _Specifiers = specifiers.ToArray();
    }

    internal CompositeFormatSpecifier(IFormatSpecifier<T>[] specifiers)
    {
        _Specifiers = specifiers;
    }

    public void WriteTo(TextWriter writer, T value, IFormatProvider formatProvider)
    {
        foreach (var s in _Specifiers)
        {
            s.WriteTo(writer, value, formatProvider);
        }
    }

    public bool TryFormat(Span<char> destination, out int charsWritten, T value, IFormatProvider formatProvider)
    {
        var rem = destination;
        charsWritten = 0;
        foreach (var s in _Specifiers)
        {
            if (!s.TryFormat(rem, out var sl, value, formatProvider))
            {
                return false;
            }
            rem = rem.Slice(sl);
            charsWritten += sl;
        }

        return true;
    }
}
