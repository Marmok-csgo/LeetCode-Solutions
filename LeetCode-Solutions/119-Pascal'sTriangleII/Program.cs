using System;
using System.Collections.Generic;

public class Solution
{
    public IList<int> GetRow(int rowIndex)
    {
        List<List<int>> t = new List<List<int>>();

        for (int i = 0; i < 38; i++)
        {
            List<int> r = new List<int>(i + 1);
            for (int j = 0; j < i + 1; j++)
            {
                r.Add(1);
            }

            for (int j = 1; j < i; j++)
            {
                r[j] = t[i - 1][j - 1] + t[i - 1][j];
            }

            t.Add(r);
        }

        return t[rowIndex];
    }
}
