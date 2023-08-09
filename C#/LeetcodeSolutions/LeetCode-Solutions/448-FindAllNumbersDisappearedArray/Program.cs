using System;
using System.Collections.Generic;

public class Solution
{
    public IList<int> FindDisappearedNumbers(int[] nums)
    {
        HashSet<int> numsSet = new HashSet<int>(nums);
        List<int> result = new List<int>();

        for (int i = 1; i <= nums.Length; i++)
        {
            if (!numsSet.Contains(i))
            {
                result.Add(i);
            }
        }

        return result;
    }
}
