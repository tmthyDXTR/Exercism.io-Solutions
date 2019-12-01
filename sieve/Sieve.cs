using System;
using System.Collections.Generic;
using System.Linq;

public static class Sieve
{
    public static int[] Primes(int limit)
    {
        if (limit < 2) throw new ArgumentOutOfRangeException("Limit too low.");
        
        HashSet<int> primes = new HashSet<int>();
        Dictionary<int, bool> numbers = new Dictionary<int, bool>();
        for (int i = 2; i <= limit; i++)
        {
            numbers.Add(i, true);
            primes.Add(i);
        }

        foreach (int number in numbers.Keys.ToList())
        {
            for (int i = 2; i * number <= limit; i++)
            {
                int mult = i * number;
                numbers[mult] = false;
                if (primes.Contains(mult))
                {
                    primes.Remove(mult);
                }
            }
        }
        return primes.ToArray();
    }
}