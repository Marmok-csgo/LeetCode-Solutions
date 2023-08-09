using System;
using System.Collections.Generic;

public class Solution
{
    public int[] Intersect(int[] nums1, int[] nums2)
    {
        Dictionary<int, int> hashMap = new Dictionary<int, int>();
        List<int> result = new List<int>();

        foreach (int num in nums1)
        {
            if (hashMap.ContainsKey(num))
                hashMap[num]++;
            else
                hashMap[num] = 1;
        }

        foreach (int num in nums2)
        {
            if (hashMap.ContainsKey(num) && hashMap[num] != 0)
            {
                result.Add(num);
                hashMap[num]--;
            }
        }

        return result.ToArray();
    }
}
