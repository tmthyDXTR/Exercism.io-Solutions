using System;
using System.Collections.Generic;

public static class NucleotideCount
{  
    public static IDictionary<char, int> Count(string sequence)
    {
        Dictionary<char, int> nucleotides = new Dictionary<char, int>()
        {
            ['A'] = 0,
            ['C'] = 0,
            ['G'] = 0,
            ['T'] = 0
        };
        for (int i = 0; i < sequence.Length; i++)
        {
            if (nucleotides.ContainsKey(sequence[i]))            
                nucleotides[sequence[i]] += 1;            
            else            
                throw new ArgumentException("Invalid DNA strand");            
        }
        return nucleotides;
    }
}