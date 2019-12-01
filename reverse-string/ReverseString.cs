using System;

public static class ReverseString
{
    public static string Reverse(string input)
    {
        char[] word = input.ToCharArray();
        Array.Reverse(word);
        return new string(word);
    }
}