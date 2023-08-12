using System;

public class Solution {
    public double FindMaxAverage(int[] nums, int k) {
        int s = 0;
        for (int i = 0; i < k; i++) {
            s += nums[i];
        }
        
        int maxSum = s;
        
        for (int i = 0; i < nums.Length - k; i++) {
            s = s + nums[i + k] - nums[i];
            maxSum = Math.Max(maxSum, s);
        }

        return (double)maxSum / k;
    }
}