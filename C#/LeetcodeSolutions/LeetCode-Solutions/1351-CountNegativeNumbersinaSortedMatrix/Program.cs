using System;
using System.Collections.Generic;

public class Solution
{
    public int CountNegatives(int[][] grid)
    {
        int count = 0;

        foreach (int[] row in grid)
        {
            foreach (int num in row)
            {
                if (num < 0)
                {
                    count++;
                }
            }
        }

        return count;
    }
}