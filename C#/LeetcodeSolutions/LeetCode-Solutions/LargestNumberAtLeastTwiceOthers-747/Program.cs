using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int DominantIndex(int[] nums)
    {
        List<int> l = nums.OrderByDescending(n => n).ToList();
        
        if (l[0] >= 2 * l[1])
        {
            return Array.IndexOf(nums, nums.Max());
        }
        
        return -1;
    }
}