using System;
using System.Collections.Generic;

public class Solution
{
    public int[] CountBits(int n)
    {
        int[] list1 = new int[n + 1];
        for (int i = 0; i <= n; i++)
        {
            int sum = CountOnesInBinary(i);
            list1[i] = sum;
        }
        return list1;
    }

    private int CountOnesInBinary(int num)
    {
        int count = 0;
        while (num > 0)
        {
            count += num & 1;
            num >>= 1;
        }
        return count;
    }
}
