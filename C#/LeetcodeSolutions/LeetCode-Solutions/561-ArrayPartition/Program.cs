public class Solution
{
    public int ArrayPairSum(int[] nums)
    {
        Array.Sort(nums);
        int maxSum = 0;
        
        for (int i = 0; i < nums.Length; i += 2)
        {
            maxSum += nums[i];
        }
        
        return maxSum;
    }
}