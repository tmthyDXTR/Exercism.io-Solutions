using System;
using System.Collections.Generic;
public static class Series
{
    public static string[] Slices(string numbers, int sliceLength)
    {        
        if (sliceLength > numbers.Length) throw new ArgumentException("slice too long");
        if (sliceLength <= 0) throw new ArgumentException("slice cannot be zero or negative");

        var list = new List<string>();
        for (int i = 0; i <= numbers.Length - sliceLength; i++)
        {
            list.Add(numbers.Substring(i, sliceLength));
        }
        return list.ToArray();
    }
}