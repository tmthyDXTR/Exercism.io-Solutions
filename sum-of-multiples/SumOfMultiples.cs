using System;
using System.Collections.Generic;
using System.Linq;

public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
    {
        List<int> factors = new List<int>();
        foreach (int factor in multiples)
        {
            for (int i = factor; i < max; i += factor)
            {
                if (factor == 0)
                {
                    break;
                }
                if (!factors.Contains(i))
                {
                    factors.Add(i);
                }
            }                     
        }
        return factors.Sum();
    }    
}