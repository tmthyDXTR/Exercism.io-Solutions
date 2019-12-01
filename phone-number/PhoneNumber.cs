using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

public class PhoneNumber
{
    public static string Clean(string phoneNumber)
    {
        string cleanNo = new String(phoneNumber.Where(Char.IsDigit).ToArray());
        if (cleanNo.Length == 11 && cleanNo.Substring(0, 1) == "1")
        {
            cleanNo = new String(cleanNo.Remove(0, 1));
        }
        
        if(cleanNo.Length == 10 && cleanNo.Substring(0, 1) != "0"
            && cleanNo.Substring(0, 1) != "1"
            && cleanNo.Substring(3, 1) != "0"
            && cleanNo.Substring(3, 1) != "1")
        {
            return cleanNo;
        }      
        else
        {
            throw new ArgumentException("Number invalid");
        }
    }
}