public class Solution
{
    public bool NZ(int num)
    {
        return !num.ToString().Contains('0');
    }

    public int[] GetNoZeroIntegers(int n)
    {
        for (int i = 1; i < n; i++)
        {
            if (NZ(i) && NZ(n - i))
            {
                return new int[] { i, n - i };
            }
        }

        return null; 
    }
}