using System;
using System.Collections.Generic;

public class Solution
{
    public IList<IList<int>> Generate(int numRows)
    {
        List<IList<int>> t = new List<IList<int>>();

        for (int i = 0; i < numRows; i++)
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

        return t;
    }
}
