using System;

public static class Raindrops
{
    public static string Convert(int number)
    {
        string rain = String.Empty;
        if (number % 3 == 0)
            rain += "Pling";
        if (number % 5 == 0)
            rain += "Plang";
        if (number % 7 == 0)
            rain += "Plong";
        if (number < 3 || rain.Length == 0)
            return number.ToString();
        return rain;
    }
}