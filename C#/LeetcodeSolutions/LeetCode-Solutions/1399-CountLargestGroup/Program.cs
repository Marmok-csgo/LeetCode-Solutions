using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int CountLargestGroup(int n)
    {
        List<int> res = new List<int>();
        for (int i = 1; i <= n; i++)
        {
            int sumDigits = i.ToString().Sum(c => int.Parse(c.ToString()));
            res.Add(sumDigits);
        }
        
        Dictionary<int, int> counter = res.GroupBy(x => x)
            .ToDictionary(g => g.Key, g => g.Count());
        
        int maxValue = counter.Values.Max();
        int count = counter.Count(kv => kv.Value == maxValue);
        
        return count;
    }
}