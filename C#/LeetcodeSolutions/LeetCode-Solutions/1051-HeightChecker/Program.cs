public class Solution {
    public int HeightChecker(int[] heights) {
        int[] sortedHeights = (int[])heights.Clone();
        Array.Sort(sortedHeights);
        
        int count = 0;
        for (int i = 0; i < heights.Length; i++) {
            if (heights[i] != sortedHeights[i]) {
                count++;
            }
        }
        
        return count;
    }
}