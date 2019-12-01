using System;
using System.Collections.Generic;
using System.Linq;

public static class Triangle
{
    private static List<double> sides;

    public static bool IsScalene(double side1, double side2, double side3)
    {
        sides = new List<double> { side1, side2, side3 };
        return sides.Distinct().Count() == 3
            && CheckTriangleInequality(sides);
    }

    public static bool IsIsosceles(double side1, double side2, double side3) 
    {
        sides = new List<double> { side1, side2, side3 };
        return sides.Distinct().Count() <= 2
            && CheckTriangleInequality(sides);
    }

    public static bool IsEquilateral(double side1, double side2, double side3) 
    {
        sides = new List<double> { side1, side2, side3 };
        return sides.Distinct().Count() == 1 && sides.Sum() > 0;
    }

    private static bool CheckTriangleInequality(List<double> list)
    {
        return list[0] + list[1] > list[2]
            && list[0] + list[2] > list[1]
            && list[1] + list[2] > list[0];
    }
}