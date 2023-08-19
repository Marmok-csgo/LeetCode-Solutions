using System;
using System.Collections.Generic;

public class Solution
{
    public bool CheckStraightLine(int[][] coordinates)
    {
        int n = coordinates.Length;

        int[] point1 = coordinates[0];
        int[] point2 = coordinates[1];

        int x1 = point1[0];
        int y1 = point1[1];

        int x2 = point2[0];
        int y2 = point2[1];

        for (int i = 2; i < n; i++)
        {
            int[] point = coordinates[i];
            int x = point[0];
            int y = point[1];

            if ((y - y1) * (x - x2) != (y - y2) * (x - x1))
            {
                return false;
            }
        }

        return true;
    }
}