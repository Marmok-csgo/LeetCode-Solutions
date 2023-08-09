using System;
using System.Collections.Generic;

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> numDict = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            if (numDict.ContainsKey(complement))
            {
                return new int[] { numDict[complement], i };
            }
            numDict[nums[i]] = i;
        }

        return new int[0];
    }
}
