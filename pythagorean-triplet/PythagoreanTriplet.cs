using System;
using System.Collections.Generic;

public static class PythagoreanTriplet
{
    public static IEnumerable<(int a, int b, int c)> TripletsWithSum(int sum)
    {
        List<(int a, int b, int c)> list = new List<(int a, int b, int c)>();
        int a;
        for (a = 1; a <= sum / 3; a++)
        {
            int b;
            for (b = a + 1; b <= sum / 2; b++)
            {
                int c = sum - a - b;
                if (a * a + b * b == c * c)
                    list.Add((a, b, c));                 
            }
        }
        return list;
    }
}