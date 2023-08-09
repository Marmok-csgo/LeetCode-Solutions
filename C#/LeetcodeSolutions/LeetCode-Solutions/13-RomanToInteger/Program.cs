public class Solution
{
    public int RomanToInt(string s)
    {
        int total = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (i + 1 >= s.Length || ToInt(s[i]) >= ToInt(s[i + 1]))
                total += ToInt(s[i]);
            else
                total -= ToInt(s[i]);
        }
        return total;
    }

    public int ToInt(char c)
    {
        return c switch
        {
            'I' => 1,
            'V' => 5,
            'X' => 10,
            'L' => 50,
            'C' => 100,
            'D' => 500,
            'M' => 1000,
            _ => 0,
        };
    }
}