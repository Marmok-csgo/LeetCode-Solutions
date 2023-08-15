using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public bool HasGroupsSizeX(int[] deck)
    {
        Dictionary<int, int> counter = new Dictionary<int, int>();
        
        foreach (int card in deck)
        {
            if (counter.ContainsKey(card))
                counter[card]++;
            else
                counter[card] = 1;
        }

        int[] values = counter.Values.ToArray();
        int gcdResult = values[0];
        for (int i = 1; i < values.Length; i++)
        {
            gcdResult = GCD(gcdResult, values[i]);
            if (gcdResult == 1)
                return false;
        }

        return gcdResult >= 2;
    }

    private int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
}