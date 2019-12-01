using System;
using System.Collections.Generic;
using System.Linq;

public enum Classification
{
    Perfect,
    Abundant,
    Deficient
}

public static class PerfectNumbers
{
    public static Classification Classify(int number)
    {
        if (number < 1) throw new ArgumentOutOfRangeException("must be positive integer");
  
        int counter = 0;
        var divisorList = new List<int>();
        while (counter + 1 <= number/2)
        {
            counter++;
            if ( number % counter == 0)
            {
                divisorList.Add(counter);
            }                   
        }
        int sum = divisorList.Sum();
        if (sum < number)
        {
            return Classification.Deficient;
        }
        else if (sum > number)
        {
            return Classification.Abundant;
        }
        else
        {
            return Classification.Perfect;
        }
    }
}