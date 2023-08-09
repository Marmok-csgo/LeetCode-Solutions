using System;
using System.Collections.Generic;

public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
        {
            return false;
        }

        Dictionary<char, int> sFrequency = new Dictionary<char, int>();
        Dictionary<char, int> tFrequency = new Dictionary<char, int>();

        foreach (char c in s)
        {
            if (sFrequency.ContainsKey(c))
            {
                sFrequency[c]++;
            }
            else
            {
                sFrequency[c] = 1;
            }
        }

        foreach (char c in t)
        {
            if (tFrequency.ContainsKey(c))
            {
                tFrequency[c]++;
            }
            else
            {
                tFrequency[c] = 1;
            }
        }

        foreach (char c in sFrequency.Keys)
        {
            if (!tFrequency.ContainsKey(c) || tFrequency[c] != sFrequency[c])
            {
                return false;
            }
        }

        return true;
    }
}
