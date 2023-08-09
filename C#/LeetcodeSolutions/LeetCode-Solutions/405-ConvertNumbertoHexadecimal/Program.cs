using System.Text;

public class Solution
{
    private const uint HexBase = 16;

    private const int MaxHexDigitsForInt = 8;

    private static readonly char[] s_hexDigits =
        { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'a', 'b', 'c', 'd', 'e', 'f' };

    public string ToHex(int num)
    {
        var n = (uint)num;

        var str = new StringBuilder(MaxHexDigitsForInt, MaxHexDigitsForInt);
        while (n > 0)
        {
            var r = n % HexBase;
            str.Insert(0, s_hexDigits[r]);
            n /= HexBase;
        }
        if (str.Length == 0)
            str.Append('0');

        return str.ToString();
    }
}