public class Solution
{
    public string ReverseStr(string s, int k)
    {
        if (s.Length < k)
            return new string(s.Reverse().ToArray());

        if (s.Length < 2 * k)
            return new string(s.Substring(0, k).Reverse().ToArray()) + s.Substring(k);

        return new string(s.Substring(0, k).Reverse().ToArray()) +
               s.Substring(k, k) +
               ReverseStr(s.Substring(2 * k), k);
    }
}