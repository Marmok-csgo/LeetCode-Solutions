using System;
using System.Collections.Generic;

public class Solution
{
    public bool IsIsomorphic(string s, string t)
    {
        if (s.Length != t.Length)
            return false;

        Dictionary<char, char> sToTMapping = new Dictionary<char, char>();
        Dictionary<char, char> tToSMapping = new Dictionary<char, char>();

        for (int i = 0; i < s.Length; i++)
        {
            char sChar = s[i];
            char tChar = t[i];

            if (sToTMapping.TryGetValue(sChar, out char mappedTChar))
            {
                if (mappedTChar != tChar)
                    return false;
            }
            else
            {
                sToTMapping[sChar] = tChar;
            }

            if (tToSMapping.TryGetValue(tChar, out char mappedSChar))
            {
                if (mappedSChar != sChar)
                    return false;
            }
            else
            {
                tToSMapping[tChar] = sChar;
            }
        }

        return true;
    }
}
