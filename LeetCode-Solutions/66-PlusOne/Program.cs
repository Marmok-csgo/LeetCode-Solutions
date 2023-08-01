public class Solution
{
    public int[] PlusOne(int[] digits)
    {
        int n = digits.Length;
        List<int> result = new List<int>();

        int carry = 1;

        for (int i = n - 1; i >= 0; i--)
        {
            int sum = digits[i] + carry;
            result.Add(sum % 10);
            carry = sum / 10;
        }

        if (carry > 0)
        {
            result.Add(carry);
        }

        result.Reverse();

        return result.ToArray();
    }
}
