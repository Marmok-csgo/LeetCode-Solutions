using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int SmallestRangeI(int[] A, int K)
    {
        int max = A.Max();
        int min = A.Min();
        int diff = max - min;
        int ex = 2 * K;

        if (diff <= ex)
        {
            return 0;
        }
        else
        {
            return diff - ex;
        }
    }
}