using System;
using System.Collections.Generic;

public static class DifferenceOfSquares
{
    public static int CalculateSquareOfSum(int max)
    {
        double sum = 0;
        for (double i = 1; i <= max; i++)
        {
            sum += i;
        }
        return (int)Math.Pow(sum, 2);
    }

    public static int CalculateSumOfSquares(int max)
    {
        double sum = 0;
        for (double i = 1; i <= max; i++)
        {
            sum += Math.Pow(i, 2);
        }
        return (int)sum;
    }

    public static int CalculateDifferenceOfSquares(int max)
    {
        return CalculateSquareOfSum(max) - CalculateSumOfSquares(max);
    }
}