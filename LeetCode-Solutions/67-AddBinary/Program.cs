public class Solution
{
    public string AddBinary(string a, string b)
    {
        int carry = 0;
        string result = "";
        int i = a.Length - 1;
        int j = b.Length - 1;

        while (i >= 0 || j >= 0)
        {
            int sum = carry;
            if (i >= 0)
            {
                sum += int.Parse(a[i].ToString());
                i--;
            }
            if (j >= 0)
            {
                sum += int.Parse(b[j].ToString());
                j--;
            }
            result = (sum % 2).ToString() + result;
            carry = sum / 2;
        }

        if (carry != 0)
        {
            result = carry.ToString() + result;
        }

        return result;
    }
}
