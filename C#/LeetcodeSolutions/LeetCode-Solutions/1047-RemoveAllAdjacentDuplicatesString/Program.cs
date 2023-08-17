public class Solution {
    public string RemoveDuplicates(string s) {
        for (int i = 0; i < s.Length - 1; i++)
        {
            if (s[i].ToString() == s[i + 1].ToString())
            {
                s = s.Remove(i, 2); 
                i = Math.Max(-1, i - 2);
            }
        }
        return s;
    }
}