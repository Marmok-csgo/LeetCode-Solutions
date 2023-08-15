public class Solution {
    public int[] SortArrayByParityII(int[] nums) {
        List<int> answer = new List<int>();

        List<int> even = new List<int>();
        List<int> odd = new List<int>();

        foreach (int n in nums) {
            if (n % 2 == 0) {
                even.Add(n);
            } else {
                odd.Add(n);
            }
        }

        for (int i = 0; i < even.Count; i++) {
            answer.Add(even[i]);
            answer.Add(odd[i]);
        }

        return answer.ToArray();
    }
}