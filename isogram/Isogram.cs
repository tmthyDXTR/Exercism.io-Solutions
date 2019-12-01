using System;
using System.Collections.Generic;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        HashSet<char> set = new HashSet<char>();
        foreach (char c in word.ToLower())
            if (!set.Add(c) && char.IsLetter(c))
            {
                return false;
                break;
            }
        return true;
    }
}
