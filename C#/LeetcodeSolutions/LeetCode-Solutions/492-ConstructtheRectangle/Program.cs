using System;
using System.Collections.Generic;

public class Solution
{
    public int[] ConstructRectangle(int area)
    {
        for (int l = (int)Math.Sqrt(area); l > 0; l--)
        {
            if (area % l == 0)
            {
                return new int[] { area / l, l };
            }
        }
        return new int[] { };
    }
}