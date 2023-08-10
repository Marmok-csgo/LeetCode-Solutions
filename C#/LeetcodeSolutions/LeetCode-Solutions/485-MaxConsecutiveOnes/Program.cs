using System;
using System.Collections.Generic;

public class Solution
{
    public int FindMaxConsecutiveOnes(int[] nums)
    {
        List<int> numsList = new List<int>(nums);
        numsList.Add(0);
        int res = 0, x = 0;
        
        foreach (int num in numsList)
        {
            if (num == 1)
            {
                x++;
            }
            else
            {
                res = Math.Max(x, res);
                x = 0;
            }
        }
        
        return res;
    }
}