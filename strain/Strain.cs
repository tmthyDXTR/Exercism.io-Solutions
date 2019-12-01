using System;
using System.Collections.Generic;
using System.Linq;

public static class Strain
{
    public static IEnumerable<T> Keep<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
    {
        IEnumerable<T> output = collection.Where(x => predicate(x));
        return output;
    }

    public static IEnumerable<T> Discard<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
    {
        IEnumerable<T> output = collection.Where(x => !predicate(x));
        return output;
    }
}