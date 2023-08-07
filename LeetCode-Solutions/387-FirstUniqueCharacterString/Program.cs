using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int FirstUniqChar(string s)
    {
        Dictionary<char, int> contador = new Dictionary<char, int>();

        foreach (char c in s)
        {
            if (contador.ContainsKey(c))
                contador[c]++;
            else
                contador[c] = 1;
        }

        for (int i = 0; i < s.Length; i++)
        {
            if (contador[s[i]] == 1)
            {
                return i;
            }
        }

        return -1;
    }
}
