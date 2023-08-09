using System;

public class Solution
{
    public int TitleToNumber(string columnTitle)
    {
        int ans = 0;
        int pos = 0;
        for (int i = columnTitle.Length - 1; i >= 0; i--)
        {
            int digit = columnTitle[i] - 'A' + 1;
            ans += digit * (int)Math.Pow(26, pos);
            pos++;
        }
        return ans;
    }
}
