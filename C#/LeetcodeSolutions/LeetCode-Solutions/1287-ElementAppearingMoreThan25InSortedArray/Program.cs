using System;
using System.Collections.Generic;

public class Solution
{
    public int FindSpecialInteger(int[] arr)
    {
        int check = arr.Length / 4;
        
        foreach (int num in new HashSet<int>(arr))
        {
            int count = 0;
            foreach (int n in arr)
            {
                if (n == num)
                    count++;
                if (count > check)
                    return num;
            }
        }

        throw new InvalidOperationException("No special integer found.");
    }
}