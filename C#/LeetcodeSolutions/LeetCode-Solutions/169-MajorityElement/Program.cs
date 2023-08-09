using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int MajorityElement(int[] nums)
    {
        Dictionary<int, int> c = new Dictionary<int, int>();

        foreach (int num in nums)
        {
            if (!c.ContainsKey(num))
            {
                c[num] = 1;
            }
            else
            {
                c[num]++;
            }
        }

        int value = 0;
        int count = 0;
        foreach (KeyValuePair<int, int> entry in c)
        {
            if (entry.Value > count)
            {
                value = entry.Key;
                count = entry.Value;
            }
        }

        return value;
    }
}
