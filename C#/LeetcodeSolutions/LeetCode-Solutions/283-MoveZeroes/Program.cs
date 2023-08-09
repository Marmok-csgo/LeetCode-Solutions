using System;

public class Solution
{
    public void MoveZeroes(int[] nums)
    {
        int zeroPos = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                int temp = nums[i];
                nums[i] = nums[zeroPos];
                nums[zeroPos] = temp;
                zeroPos++;
            }
        }
    }
}
