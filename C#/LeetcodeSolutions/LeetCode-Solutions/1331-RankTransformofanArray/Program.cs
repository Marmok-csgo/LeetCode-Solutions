using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int[] ArrayRankTransform(int[] arr)
    {
        Dictionary<int, int> rank = new Dictionary<int, int>();
        foreach (int a in arr.OrderBy(x => x))
        {
            if (!rank.ContainsKey(a))
            {
                rank[a] = rank.Count + 1;
            }
        }

        return arr.Select(a => rank[a]).ToArray();
    }
}