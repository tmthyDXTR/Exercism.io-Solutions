using System;
using System.Collections.Generic;

public static class PascalsTriangle
{
    public static IEnumerable<IEnumerable<int>> Calculate(int rows)
    {
        List<List<int>> pascal = new List<List<int>>();

        for (int rowIndex = 0; rowIndex < rows; rowIndex++)
        {
            List<int> row = new List<int>();

            for (int rowItem = 0; rowItem <= rowIndex; rowItem++)
            {
                if (rowItem == 0 || rowItem == rowIndex)
                {
                    row.Add(1);
                }
                else
                {
                    row.Add(pascal[rowIndex - 1][rowItem - 1] + pascal[rowIndex - 1][rowItem]);
                }
            }
            pascal.Add(row);
        }

        return pascal;
    }
}