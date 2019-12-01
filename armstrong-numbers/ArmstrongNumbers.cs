using System;

public static class ArmstrongNumbers
{
    public static bool IsArmstrongNumber(int number)
    {
        string num = number.ToString();
        double sum = 0;
        foreach (char digit in num)         
        {
            sum += Math.Pow(char.GetNumericValue(digit), num.Length);
        }
        return sum == number;
    }
}