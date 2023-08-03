public class Solution
{
    public string ConvertToTitle(int columnNumber)
    {
        string output = "";
        while (columnNumber > 0)
        {
            char ch = (char)('A' + (columnNumber - 1) % 26);
            output = ch + output;
            columnNumber = (columnNumber - 1) / 26;
        }
        return output;
    }
}
