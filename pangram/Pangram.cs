using System;

public static class Pangram
{
    public static bool IsPangram(string input)
    {        
        string alpha = "abcdefghijklmnopqrstuvwxyz";
        int count = 0;
        foreach (char c in alpha)
        {
            if (input.ToLower().Contains(c))
            {
                count++;
            }
        }
        if (count >= 26)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
