using System;
using System.Collections.Generic;

public class Solution
{
    public bool CheckPerfectNumber(int num)
    {
        HashSet<int> perfectNumbers = new HashSet<int>
        {
            6, 28, 496, 8128, 33550336, 858986905
        };

        return perfectNumbers.Contains(num);
    }
}