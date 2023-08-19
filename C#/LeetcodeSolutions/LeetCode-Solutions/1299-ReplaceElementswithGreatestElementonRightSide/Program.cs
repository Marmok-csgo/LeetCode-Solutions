using System;
using System.Collections.Generic;

public class Solution
{
    public int[] ReplaceElements(int[] arr)
    {
        int maxi = -1;
        int n = arr.Length;
        
        for (int i = n - 1; i >= 0; i--)
        {
            int temp = arr[i];
            arr[i] = maxi;
            maxi = Math.Max(maxi, temp);
        }
        
        return arr;
    }
}