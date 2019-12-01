using System;

public static class Darts
{
    public static int Score(double x, double y)
        => Toss(x, y) <= Radius(1) ? 10
        : Toss(x, y) <= Radius(5) ? 5
        : Toss(x, y) <= Radius(10) ? 1
        : 0;

    private static double Toss(double x, double y)
        => Math.Pow((x - 0), 2) + Math.Pow((y - 0), 2);
    
    private static double Radius(double r)
        => Math.Pow(r, 2);
}