using System;
using System.Collections.Generic;
using System.Linq;

public class NumArray
{
    private int[] nums;

    public NumArray(int[] nums)
    {
        this.nums = new int[nums.Length + 1];
        for (int i = 0; i < nums.Length; i++)
        {
            this.nums[i + 1] = this.nums[i] + nums[i];
        }
    }

    public int SumRange(int left, int right)
    {
        return this.nums[right + 1] - this.nums[left];
    }
}
