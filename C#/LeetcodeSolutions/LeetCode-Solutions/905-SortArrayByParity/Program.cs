using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int[] SortArrayByParity(int[] nums)
    {
        List<int> evenNumbers = nums.Where(i => i % 2 == 0).ToList();
        List<int> oddNumbers = nums.Where(j => j % 2 != 0).ToList();
        
        evenNumbers.AddRange(oddNumbers);
        
        return evenNumbers.ToArray();
    }
}