using System;
using System.Collections.Generic;
using System.Linq;

public static class ScrabbleScore
{
    private static readonly Dictionary<string, int> letterValues = new Dictionary<string, int>()
    {
        { "AEIOULNRST", 1 },
        { "DG", 2 },
        { "BCMP", 3 },
        { "FHVWY", 4 },
        { "K", 5 },
        { "JX", 8 },
        { "QZ", 10 }
    };    
   
    public static int Score(string input)
    {
        int score = 0;
        foreach (char c in input.ToUpper().ToCharArray())
        {
            foreach (KeyValuePair<string, int> letter in letterValues)
            {
                if (letter.Key.Contains(c))
                {
                    score += letter.Value;
                }
            }
        }
        return score;
    }
}