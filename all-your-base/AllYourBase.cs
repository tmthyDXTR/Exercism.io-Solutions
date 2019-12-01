using System;
using System.Collections.Generic;
using System.Linq;

public static class AllYourBase
{
    public static int[] Rebase(int inputBase, int[] inputDigits, int outputBase)
    {
        if (inputBase < 2 || outputBase < 2)
            throw new ArgumentException("Invalid input or output base");

        if (inputDigits.Any(n => n < 0 || n >= inputBase))
            throw new ArgumentException("Invalid input digit");

        int input = inputDigits
            .Select((t, i) => t * (int)(Math.Pow(inputBase, inputDigits.Length - i - 1)))
            .Sum();

        List<int> output = new List<int>();
        
        while (input > 0)
        {
            output.Add(input % outputBase);
            input /= outputBase;
        }

        return output.DefaultIfEmpty().Reverse().ToArray();
    }
}