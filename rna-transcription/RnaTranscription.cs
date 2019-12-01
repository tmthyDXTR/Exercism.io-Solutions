using System;
using System.Collections.Generic;
using System.Linq;

public static class RnaTranscription
{
    private static Dictionary<char, char> DnaToRna = new Dictionary<char, char> 
    { 
        { 'A', 'U' }, 
        { 'C', 'G' }, 
        { 'G', 'C' }, 
        { 'T', 'A' } 
    };
    private static Dictionary<char, char> RnaToDna = new Dictionary<char, char>
    {
        { 'U', 'A' },
        { 'G', 'C' },
        { 'C', 'G' },
        { 'A', 'T' }
    };


    public static string ToRna(string nucleotide) => string.Concat(nucleotide.Select(x => DnaToRna[x]));
    public static string ToDna(string nucleotide) => string.Concat(nucleotide.Select(x => RnaToDna[x]));
}