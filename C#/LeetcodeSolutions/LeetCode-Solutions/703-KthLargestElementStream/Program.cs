using System;
using System.Collections.Generic;

public class KthLargest
{
    private List<int> arr;
    private int n;

    public KthLargest(int k, int[] nums)
    {
        arr = new List<int>();
        n = k;
        foreach (int num in nums)
        {
            Push(num);
        }
    }

    private void Push(int val)
    {
        if (arr.Count == n)
        {
            int top = arr[0];
            arr.RemoveAt(0);
            if (top > val)
            {
                Insert(top);
            }
            else
            {
                Insert(val);
            }
        }
        else
        {
            Insert(val);
        }
    }

    private void Insert(int val)
    {
        int index = arr.BinarySearch(val);
        if (index < 0)
            index = ~index;
        arr.Insert(index, val);
    }

    public int Add(int val)
    {
        Push(val);
        return arr.Count > 0 ? arr[0] : -1;
    }
}