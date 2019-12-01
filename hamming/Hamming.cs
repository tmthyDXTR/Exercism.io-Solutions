using System;

public static class Hamming
{
    public static int Distance(string firstStrand, string secondStrand)
    {        
        int diff = 0;
        if (firstStrand.Length != secondStrand.Length) throw new ArgumentException("not same length");
        for (int i = 0; i < firstStrand.Length; i++)
        {
            if (firstStrand[i] != secondStrand[i])
            {
                diff++;
            }
        }
        return diff;
    }
}