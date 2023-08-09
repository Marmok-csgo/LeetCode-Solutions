using System;
using System.Collections.Generic;

public class Solution
{
    public int FindContentChildren(int[] g, int[] s)
    {
        Array.Sort(g);
        Array.Sort(s);

        int i = 0, j = 0, ans = 0;
        while (i < s.Length && j < g.Length)
        {
            if (g[j] <= s[i])
            {
                ans++;
                j++;
            }
            i++;
        }

        return ans;
    }
}
