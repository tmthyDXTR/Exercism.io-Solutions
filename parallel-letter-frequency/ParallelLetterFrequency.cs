using System;
using System.Collections.Generic;
using System.Linq;

public static class ParallelLetterFrequency
{
    public static Dictionary<char, int> Calculate(IEnumerable<string> texts)
    {
        return texts
            .AsParallel()
            .SelectMany(txt => txt.ToLower().ToCharArray())
            .GroupBy(chr => chr)
            .Where(grp => char.IsLetter(grp.Key))
            .ToDictionary(grp => grp.Key, grp => grp.Count());
    }
}