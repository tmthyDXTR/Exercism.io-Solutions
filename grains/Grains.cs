using System;
using System.Collections;

public static class Grains
{
    public static ulong Square(int n) 
    {                
        if (n > 0 && n <= 64)
        {
            return (ulong)Math.Pow(2, n - 1);
        }
        else
        {
            throw new ArgumentOutOfRangeException("Input must be: 0 < input <= 64");
        }           
    }

    public static ulong Total()
    {
        ulong total = 0UL;
        for (int p = 0; p <= 64; p++)
        {
            total += (ulong)Math.Pow(2, p);
        }
        return total;
    }
}