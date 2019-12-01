using System;

public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        string[] words = phrase.ToUpper().Split(
            new string[] { " ", "-", "_" }, 
            StringSplitOptions.RemoveEmptyEntries);
        string acro = "";
        foreach (string word in words)
        {
            acro += word[0];
        }
        return acro;
    }
}