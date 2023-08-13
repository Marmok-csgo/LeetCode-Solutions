using System;
using System.Collections.Generic;

public class Solution
{
    public IList<int> SelfDividingNumbers(int left, int right)
    {
        List<int> v = new List<int>();

        for (int x = left; x <= right; x++)
        {
            List<char> a = new List<char>(x.ToString().ToCharArray());
            bool d = true;

            foreach (char r in a)
            {
                if (r != '0')
                {
                    if (x % (r - '0') != 0)
                    {
                        d = false;
                    }
                }
                else
                {
                    d = false;
                }
            }

            if (d)
            {
                v.Add(x);
            }
        }

        return v;
    }
}