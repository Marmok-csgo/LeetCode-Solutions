public class Solution
{
    public bool CheckRecord(string s)
    {
        if (s.Count(c => c == 'A') >= 2 || s.Contains("LLL"))
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}