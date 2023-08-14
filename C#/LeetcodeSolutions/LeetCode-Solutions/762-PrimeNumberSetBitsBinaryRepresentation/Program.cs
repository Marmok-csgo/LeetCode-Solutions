using System;
using System.Collections.Generic;

public class Solution
{
    private static readonly HashSet<int> Primes = new HashSet<int> { 2, 3, 5, 7, 11, 13, 17, 19 };

    public int CountPrimeSetBits(int left, int right)
    {
        int count = 0;
        
        for (int i = left; i <= right; i++)
        {
            if (IsPrimeSetBits(i))
            {
                count++;
            }
        }
        
        return count;
    }

    private bool IsPrimeSetBits(int num)
    {
        int setBitsCount = CountSetBits(num);
        return Primes.Contains(setBitsCount);
    }

    private int CountSetBits(int num)
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