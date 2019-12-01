using System;
using System.Collections.Generic;

public static class Etl
{
    public static Dictionary<string, int> Transform(Dictionary<int, string[]> oldDict)
    {
        Dictionary<string, int> newDict = new Dictionary<string, int>();
        foreach (KeyValuePair<int, string[]> points in oldDict)
        {
            foreach (string letter in points.Value)
            {
                newDict[letter.ToLower()] = points.Key;                
            }
        }
        return newDict;
    }
}