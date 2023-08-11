using System;
using System.Collections.Generic;

public class Solution
{
    public int Fib(int n)
    {
        Dictionary<int, int> mydict = new Dictionary<int, int>();
        return FibNum(n, mydict);
    }

    private int FibNum(int x, Dictionary<int, int> dic1)
    {
        if (x == 0 || x == 1)
        {
            return x;
        }
        else if (!dic1.ContainsKey(x))
        {
            dic1[x] = FibNum(x - 1, dic1) + FibNum(x - 2, dic1);
        }
        return dic1[x];
    }
}