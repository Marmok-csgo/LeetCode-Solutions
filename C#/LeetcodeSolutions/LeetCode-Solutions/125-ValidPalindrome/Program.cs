using System;
using System.Linq;

public class Solution
{
    public bool IsPalindrome(string s)
    {
        string cleanedString = new string(s.ToLower().Where(char.IsLetterOrDigit).ToArray());
        return cleanedString == new string(cleanedString.Reverse().ToArray());
    }
}
