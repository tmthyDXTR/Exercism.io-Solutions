using System;
using System.Collections.Generic;

public static class RobotSettings
{
    public static HashSet<string> Names = new HashSet<string>();
}

public class Robot
{
    private static readonly Random _rng = new Random();
    public string Name { get; private set; }

    public Robot()
    {
        Reset();
    }

    public void Reset()
    {
        GenerateName();
    }

    public void GenerateName()
    {
        do
        {
            Name = GenerateLetter()
                + GenerateLetter()
                + GenerateThreeDigits();
        }
        while (RobotSettings.Names.Contains(Name));

        RobotSettings.Names.Add(Name);
    }

    private static string GenerateLetter()
        => ((char)('A' + _rng.Next(0, 26))).ToString();

    private static string GenerateThreeDigits()
        => _rng.Next(0, 1000).ToString("000");
}