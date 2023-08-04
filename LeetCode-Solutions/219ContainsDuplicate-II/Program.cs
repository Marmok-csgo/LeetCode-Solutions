using System.Collections.Generic;

public class Solution
{
    public bool ContainsNearbyDuplicate(int[] nums, int k)
    {
        Dictionary<int, int> numIndices = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (numIndices.ContainsKey(nums[i]))
            {
                if (i - numIndices[nums[i]] <= k)
                {
                    return true;
                }
            }
            numIndices[nums[i]] = i;
        }

        return false;
    }
}
