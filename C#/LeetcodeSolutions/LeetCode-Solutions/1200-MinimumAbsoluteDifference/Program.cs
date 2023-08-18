public class Solution {
    public IList<IList<int>> MinimumAbsDifference(int[] arr) {
        
        Array.Sort(arr);
        
        int minimum_differece = Int32.MaxValue;
        
        List<IList<int>> ans = new List<IList<int>>();
        
        for(int i = 0; i < arr.Length-1; i++) {
            minimum_differece = Math.Min(minimum_differece, arr[i + 1] - arr[i]);
        }
        
        for(int i = 0; i < arr.Length-1; i++) {
            if(arr[i + 1] - arr[i] == minimum_differece)
                ans.Add(new List<int>{arr[i], arr[i+1]});
        }
        
        return ans;
    }
}