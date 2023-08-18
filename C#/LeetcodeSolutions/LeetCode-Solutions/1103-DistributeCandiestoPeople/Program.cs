public class Solution {
    public int[] DistributeCandies(int candies, int n) {
        int[] res = new int[n];
        int i = 0;
        
        while (candies > 0) {
            res[i % n] += Math.Min(candies, i + 1);
            candies -= i + 1;
            i++;
        }
        
        return res;
    }
}