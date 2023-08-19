using System;
using System.Collections.Generic;

public class Solution
{
    public bool UniqueOccurrences(int[] arr)
    {
        Dictionary<int, int> m = new Dictionary<int, int>();
        foreach (int num in arr)
        {
            if (m.ContainsKey(num))
                m[num]++;
            else
                m[num] = 1;
        }

        HashSet<int> s = new HashSet<int>();
        foreach (int cnt in m.Values)
        {
            s.Add(cnt);
        }

        return s.Count == m.Count;
    }
}