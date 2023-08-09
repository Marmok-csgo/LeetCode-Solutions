using System;
using System.Collections.Generic;

public class Solution
{
    public char FindTheDifference(string s, string t)
    {
        if (s.Length > t.Length)
        {
            foreach (char c in s)
            {
                if (CountOccurrences(s, c) > CountOccurrences(t, c))
                {
                    return c;
                }
            }
        }

        if (t.Length > s.Length)
        {
            foreach (char c in t)
            {
                if (CountOccurrences(t, c) > CountOccurrences(s, c))
                {
                    return c;
                }
            }
        }

        return '\0';
    }

    private int CountOccurrences(string str, char c)
    {
        int count = 0;
        foreach (char ch in str)
        {
            if (ch == c)
            {
                count++;
            }
        }
        return count;
    }
}
