using System;
using System.Collections.Generic;

public class Solution
{
    public bool IsBoomerang(int[][] p)
    {
        int[] point1 = p[0];
        int[] point2 = p[1];
        int[] point3 = p[2];

        Array.Sort(p, (a, b) => a[0] - b[0]);

        int x1 = point1[0], y1 = point1[1];
        int x2 = point2[0], y2 = point2[1];
        int x3 = point3[0], y3 = point3[1];

        if ((y2 - y1) * (x3 - x2) != (x2 - x1) * (y3 - y2))
        {
            return true;
        }

        return false;
    }
}