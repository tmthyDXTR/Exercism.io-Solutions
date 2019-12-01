using System;
using System.Collections.Generic;
using System.Text;

public static class RomanNumeralExtension
{
    public static readonly Dictionary<int, string> NumberRomanDictionary = new Dictionary<int, string>()
    {
        { 1000, "M" },
        { 900, "CM" },
        { 500, "D" },
        { 400, "CD" },
        { 100, "C" },
        { 90, "XC" },
        { 50, "L" },
        { 40, "XL" },
        { 10, "X" },
        { 9, "IX" },
        { 5, "V" },
        { 4, "IV" },
        { 1, "I" },
    };

    public static string ToRoman(this int value)
    {
        if (value > 3999) throw new ArgumentOutOfRangeException("Value must be < 3999.");

        StringBuilder roman = new StringBuilder();

        foreach (var item in NumberRomanDictionary)
        {
            while (value >= item.Key)
            {
                roman.Append(item.Value);
                value -= item.Key;
            }
        }

        return roman.ToString();
    }
}