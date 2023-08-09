public class Solution
{
    public bool IsPerfectSquare(int num)
    {
        var n = Math.Sqrt((double)num);
        return n == (int)n;
    }
}