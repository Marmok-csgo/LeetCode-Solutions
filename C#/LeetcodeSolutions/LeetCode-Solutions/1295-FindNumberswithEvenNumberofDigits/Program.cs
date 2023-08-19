using System;
using System.Collections.Generic;

public class Solution
{
    public int FindNumbers(int[] nums)
    {
        int count = 0;
        
        foreach (int num in nums)
        {
            if (num.ToString().Length % 2 == 0)
            {
                count++;
            }
        }
        
        return count;
    }
}