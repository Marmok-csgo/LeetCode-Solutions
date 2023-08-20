using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public bool CheckIfExist(int[] arr)
    {
        if (arr.Count(x => x == 0) > 1)
        {
            return true;
        }
        
        HashSet<int> S = new HashSet<int>(arr.Where(x => x != 0));
        
        foreach (int i in arr)
        {
            if (S.Contains(2 * i))
            {
                return true;
            }
        }

        return false;
    }
}