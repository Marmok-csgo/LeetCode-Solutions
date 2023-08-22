using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
    {
        int maxCandies = candies.Max();

        List<bool> result = new List<bool>();
        foreach (int c in candies)
        {
            result.Add(c + extraCandies >= maxCandies);
        }

        return result;
    }
}