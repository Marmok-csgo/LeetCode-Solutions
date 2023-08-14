using System;
using System.Collections.Generic;

public class Solution
{
    public bool BuddyStrings(string s, string goal)
    {
        int ns = s.Length;
        int ng = goal.Length;

        if (ns != ng)
        {
            return false;
        }

        if (s == goal)
        {
            int[] farr = new int[26];
            foreach (char ch in s)
            {
                farr[ch - 'a']++;
            }

            foreach (int count in farr)
            {
                if (count > 1)
                {
                    return true;
                }
            }

            return false;
        }

        List<int> ans = new List<int>();
        for (int i = 0; i < ns; i++)
        {
            if (s[i] != goal[i])
            {
                ans.Add(i);
                if (ans.Count > 2)
                {
                    return false;
                }
            }
        }

        return ans.Count == 2 && s[ans[0]] == goal[ans[1]] && s[ans[1]] == goal[ans[0]];
    }
}