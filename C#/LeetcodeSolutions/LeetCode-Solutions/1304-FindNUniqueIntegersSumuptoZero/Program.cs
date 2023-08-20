using System;
using System.Collections.Generic;

public class Solution
{
    public int[] SumZero(int n)
    {
        List<int> result = new List<int>();

        for (int i = 0; i < n; i++)
        {
            result.Add(i * 2 - n + 1);
        }

        return result.ToArray();
    }
}