using System;
using System.Collections.Generic;

public class Solution
{
    public int OddCells(int n, int m, int[][] indices)
    {
        int count = 0;
        int[] row = new int[n];
        int[] col = new int[m];

        foreach (int[] index in indices)
        {
            int x = index[0];
            int y = index[1];
            row[x]++;
            col[y]++;
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if ((row[i] + col[j]) % 2 == 1)
                {
                    count++;
                }
            }
        }

        return count;
    }
}