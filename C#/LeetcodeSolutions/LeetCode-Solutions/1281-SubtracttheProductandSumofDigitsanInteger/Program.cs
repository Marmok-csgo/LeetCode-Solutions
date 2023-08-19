using System;
using System.Collections.Generic;

public class Solution
{
    public int SubtractProductAndSum(int n)
    {
        List<int> l = new List<int>();
        int a = 0;
        int b = 1;
        
        while (n != 0)
        {
            int rem = n % 10;
            l.Add(rem);
            n = n / 10;
        }
        
        foreach (int i in l)
        {
            a += i;
            b *= i;
        }

        return b - a;
    }
}