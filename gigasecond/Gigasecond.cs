using System;

public static class Gigasecond
{
    public static DateTime Add(DateTime moment)
    {
        TimeSpan gigasec = TimeSpan.FromSeconds(Math.Pow(10, 9)); 
        return moment + gigasec;
    }
}