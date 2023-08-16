using System;
using System.Linq;

public class Solution
{
    public int LargestPerimeter(int[] nums)
    {
        Array.Sort(nums);
        Array.Reverse(nums);

        for (int i = 0; i < nums.Length - 2; i++)
        {
            int baseValue = nums[i];
            int side1 = nums[i + 1];
            int side2 = nums[i + 2];

            if (side1 + side2 > baseValue)
            {
                return baseValue + side1 + side2;
            }
        }

        return 0;
    }
}