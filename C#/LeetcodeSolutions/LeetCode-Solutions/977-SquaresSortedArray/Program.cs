using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int[] SortedSquares(int[] nums)
    {
        List<int> resultList = new List<int>();

        foreach (int num in nums)
        {
            int squared = (int)Math.Pow(num, 2);
            resultList.Add(squared);
        }

        return resultList.OrderBy(x => x).ToArray();
    }
}