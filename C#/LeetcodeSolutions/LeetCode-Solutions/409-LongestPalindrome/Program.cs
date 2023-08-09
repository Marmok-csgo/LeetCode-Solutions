using System;
using System.Collections.Generic;

public class Solution
{
    public int LongestPalindrome(string s)
    {
        Dictionary<char, int> charCounts = new Dictionary<char, int>();

        foreach (char c in s)
        {
            if (charCounts.ContainsKey(c))
            {
                charCounts[c]++;
            }
            else
            {
                charCounts[c] = 1;
            }
        }

        int palindromeLength = 0;
        bool hasOdd = false;

        foreach (int count in charCounts.Values)
        {
            if (count % 2 == 0)
            {
                palindromeLength += count;
            }
            else
            {
                palindromeLength += count - 1;
                hasOdd = true;
            }
        }

        if (hasOdd)
        {
            palindromeLength += 1;
        }

        return palindromeLength;
    }
}
