using System;
using System.Collections.Generic;

public class Solution
{
    public char NextGreatestLetter(char[] letters, char target)
    {
        int l = 0;
        int r = letters.Length;

        while (l < r)
        {
            int mid = (l + r) / 2;
            if (letters[mid] > target)
            {
                r = mid;
            }
            else
            {
                l = mid + 1;
            }
        }

        return r < letters.Length ? letters[r] : letters[0];
    }
}