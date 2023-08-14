using System;
using System.Collections.Generic;

public class Solution
{
    public double LargestTriangleArea(int[][] points)
    {
        double area = 0;
        int n = points.Length;

        for (int i = 0; i < n; i++)
        {
            int x1 = points[i][0];
            int y1 = points[i][1];

            for (int j = i + 1; j < n; j++)
            {
                int x2 = points[j][0];
                int y2 = points[j][1];

                for (int k = j + 1; k < n; k++)
                {
                    int x3 = points[k][0];
                    int y3 = points[k][1];

                    double curr = Math.Abs(0.5 * (x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2)));

                    if (curr > area)
                    {
                        area = curr;
                    }
                }
            }
        }

        return area;
    }
}