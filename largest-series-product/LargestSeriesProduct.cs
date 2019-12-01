using System;
using System.Linq;

public static class LargestSeriesProduct
{
    public static long GetLargestProduct(string digits, int span) 
    {
        if (span > digits.Length || span < 0 || !digits.All(char.IsDigit))
        {
            throw new ArgumentException();
        }
        long largest = 0;
        for (int i = 0; (i + span) <= digits.Length; i++)
        {
            long product = 1;
            foreach(char value in digits.ToCharArray(i, span))
            {
                product *= (long)char.GetNumericValue(value);                
            }
            if(product > largest)
            {
                largest = product;
            }
        }        
        return largest;
    }
}