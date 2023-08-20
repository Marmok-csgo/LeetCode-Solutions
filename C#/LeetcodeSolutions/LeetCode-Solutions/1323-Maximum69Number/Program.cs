public class Solution
{
    public int Maximum69Number(int num)
    {
        int m = num;
        string s = num.ToString();

        for (int i = 0; i < s.Length; i++)
        {
            int temp;
            if (s[i] == '6')
            {
                temp = int.Parse(s.Substring(0, i) + '9' + s.Substring(i + 1));
            }
            else
            {
                temp = int.Parse(s.Substring(0, i) + '6' + s.Substring(i + 1));
            }
            m = Math.Max(m, temp);
        }

        return m;
    }
}