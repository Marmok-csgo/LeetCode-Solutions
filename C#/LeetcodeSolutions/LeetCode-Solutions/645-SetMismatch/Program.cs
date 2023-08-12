using System;
using System.Collections.Generic;

public class Solution {
    public int[] FindErrorNums(int[] nums) {
        Dictionary<int, int> counter = new Dictionary<int, int>();
        int[] result = new int[2];
        
        foreach (int num in nums) {
            if (!counter.ContainsKey(num)) {
                counter[num] = 1;
            }
            else {
                counter[num]++;
            }
        }
        
        for (int i = 1; i <= nums.Length; i++) {
            if (counter.ContainsKey(i)) {
                if (counter[i] == 2) {
                    result[0] = i;
                }
            }
            else {
                result[1] = i;
            }
        }
        
        return result;
    }
}