using System;
using System.Numerics;

public class Solution
{
    public string AddStrings(string num1, string num2)
    {
        BigInteger bigint1 = BigInteger.Parse(num1);
        BigInteger bigint2 = BigInteger.Parse(num2);

        BigInteger sum = bigint1 + bigint2;

        return sum.ToString();
    }
}
