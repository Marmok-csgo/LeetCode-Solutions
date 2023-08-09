public class Solution
{
    public bool IsPalindrome(int x)
    {
        if (x < 0)
        {
            return false;
        }
        var reverse = 0;
        var temp = x;
        while (temp > 0)
        {
            reverse = reverse * 10 + temp % 10;
            temp /= 10;
        }
        return x == reverse;
    }
}