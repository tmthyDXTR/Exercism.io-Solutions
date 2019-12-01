using System;
using System.Collections.Generic;


public class SimpleCipher
{
    public SimpleCipher()
    {    
        Key = GenerateRandomKey(100);
    }    

    public SimpleCipher(string key)
    {
        Key = key;
    }

    private static string key;
    
    public string Key { 
        set { key = value; } 
        get { return key; }
    }

    public string Encode(string plainText)
    {
        List<char> _encodedText = new List<char>();
        int i = 0;
        int _keyCount = 0;
        while (i < plainText.Length)
        {
            if (_keyCount < Key.Length)
            {
                _encodedText.Add((char)(plainText[i]+Key[i]));
                i++;
                _keyCount++;
            }
            else
            {
                _keyCount = 0;
            }
        }
        return new string(string.Concat(_encodedText));
    }

    public string Decode(string cipherText)
    {
        throw new NotImplementedException("You need to implement this function.");
    }

    public string GenerateRandomKey(int length)
    {
        string _chars = "abcdefghijklmnopqrstuvwxyz";
        var _key = new char[length];
        var _random = new Random();
        for (int i = 0; i < _key.Length; i++)
        {
            _key[i] = _chars[_random.Next(_chars.Length)];
        }
        return new string(_key);
    }
}