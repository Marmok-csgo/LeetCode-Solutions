using System;
using System.Collections.Generic;

public class Solution {
    public int MaxCount(int m, int n, int[][] ops) {
        int min_y = m;
        int min_x = n;

        foreach (var op in ops) {
            int y = op[0];
            int x = op[1];
            
            min_y = Math.Min(min_y, y);
            min_x = Math.Min(min_x, x);
        }

        return min_x * min_y;
    }
}