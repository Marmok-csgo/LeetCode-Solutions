using System;
using System.Collections.Generic;

public class Solution
{
    public int MinCostClimbingStairs(int[] cost)
    {
        int prev = 0;
        int prev2 = 0;
        int curr = 0;

        for (int i = 2; i <= cost.Length; i++)
        {
            curr = Math.Min(prev + cost[i - 1], prev2 + cost[i - 2]);
            prev2 = prev;
            prev = curr;
        }

        return prev;
    }
}