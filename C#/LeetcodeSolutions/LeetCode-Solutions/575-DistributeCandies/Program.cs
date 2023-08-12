using System;
using System.Collections.Generic;

public class Solution {
    public int DistributeCandies(int[] candyType) {
        HashSet<int> setCandyType = new HashSet<int>(candyType);
        int count = candyType.Length / 2;
        
        if (count <= setCandyType.Count) {
            return count;
        }
        else {
            return setCandyType.Count;
        }
    }
}