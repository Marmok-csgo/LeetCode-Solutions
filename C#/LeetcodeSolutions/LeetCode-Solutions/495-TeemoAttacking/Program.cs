using System;
using System.Collections.Generic;

public class Solution
{
    public int FindPoisonedDuration(int[] t, int d)
    {
        int duration = d;
        for (int i = 0; i < t.Length - 1; i++)
        {
            duration += Math.Min(t[i + 1] - t[i], d);
        }
        return duration;
    }
}