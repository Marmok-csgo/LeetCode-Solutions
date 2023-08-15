using System;
using System.Collections.Generic;

public class Solution
{
    public int ProjectionArea(int[][] grid)
    {
        int ans = grid.Length * grid[0].Length;
        int[] ic = new int[grid[0].Length];

        foreach (int[] i in grid)
        {
            ans += Max(i);
            for (int m = 0; m < i.Length; m++)
            {
                int n = i[m];
                if (n == 0)
                {
                    ans -= 1;
                }
                if (n > ic[m])
                {
                    ic[m] = n;
                }
            }
        }

        ans += Sum(ic);
        return ans;
    }

    private int Max(int[] arr)
    {
        int max = arr[0];
        foreach (int num in arr)
        {
            max = Math.Max(max, num);
        }
        return max;
    }

    private int Sum(int[] arr)
    {
        int sum = 0;
        foreach (int num in arr)
        {
            sum += num;
        }
        return sum;
    }
}