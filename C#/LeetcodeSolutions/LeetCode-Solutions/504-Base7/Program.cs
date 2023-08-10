using System;

public class Solution
{
    public string ConvertToBase7(int num)
    {
        if (num == 0)
        {
            return "0";
        }

        bool isNegative = num < 0;
        if (isNegative)
        {
            num = -num;
        }

        string base7 = "";
        while (num > 0)
        {
            int remainder = num % 7;
            base7 = remainder.ToString() + base7;
            num /= 7;
        }

        if (isNegative)
        {
            base7 = '-' + base7;
        }

        return base7;
    }
}