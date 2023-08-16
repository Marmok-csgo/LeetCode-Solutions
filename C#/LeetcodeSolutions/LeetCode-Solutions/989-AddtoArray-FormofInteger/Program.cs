using System.Numerics;
public class Solution {
    public IList<int> AddToArrayForm(int[] num, int k) {
        return (BigInteger.Parse(string.Join("", num.Select(x => x))) + k).ToString().Select(x => int.Parse(x.ToString())).ToList();
    }
}