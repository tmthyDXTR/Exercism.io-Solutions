using System;
using System.Collections.Generic;
using System.Linq;

public static class ProteinTranslation
{
    public static readonly Dictionary<string, string[]> proteinsDict = new Dictionary<string, string[]>()
    {
        { "Methionine",     new [] { "AUG" } },
        { "Phenylalanine",  new [] { "UUU", "UUC" } },
        { "Leucine",        new [] { "UUA", "UUG" } },
        { "Serine",         new [] { "UCU", "UCC", "UCA", "UCG" } },
        { "Tyrosine",       new [] { "UAU", "UAC" } },
        { "Cysteine",       new [] { "UGU", "UGC" } },
        { "Tryptophan",     new [] { "UGG" } },
        { "STOP",           new [] { "UAA", "UAG", "UGA" } }
    };
    
    public static string[] Proteins(string strand)
    {
        List<string> translation = new List<string>();

        for (int i = 0; i <= (strand.Length - 3); i += 3)
        {
            string codon = strand.Substring(i, 3);
            foreach (KeyValuePair<string, string[]> protein in proteinsDict)
            {
                if (protein.Value.Contains(codon) && protein.Key == "STOP")
                    return translation.ToArray();

                if (protein.Value.Contains(codon) && protein.Key != "STOP")
                    translation.Add(protein.Key);
            }
        }
        return translation.ToArray();
    }
}