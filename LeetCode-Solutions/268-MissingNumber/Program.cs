using System;
using System.Collections.Generic;

public class Solution
{
    public int MissingNumber(int[] nums)
    {
        int length = nums.Length + 1;
        HashSet<int> numSet = new HashSet<int>(nums);

        for (int i = 0; i < length; i++)
        {
            if (!numSet.Contains(i))
            {
                return i;
            }
        }

        throw new InvalidOperationException("Input is invalid.");
    }
}
