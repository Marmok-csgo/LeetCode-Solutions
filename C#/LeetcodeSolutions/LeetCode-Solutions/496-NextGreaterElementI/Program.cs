using System;
using System.Collections.Generic;

public class Solution
{
    public int[] NextGreaterElement(int[] nums1, int[] nums2)
    {
        Dictionary<int, int> nextGreater = new Dictionary<int, int>();
        Stack<int> stack = new Stack<int>();

        foreach (int num in nums2)
        {
            while (stack.Count > 0 && num > stack.Peek())
            {
                nextGreater[stack.Pop()] = num;
            }
            stack.Push(num);
        }

        int[] result = new int[nums1.Length];
        for (int i = 0; i < nums1.Length; i++)
        {
            if (nextGreater.ContainsKey(nums1[i]))
            {
                result[i] = nextGreater[nums1[i]];
            }
            else
            {
                result[i] = -1;
            }
        }

        return result;
    }
}