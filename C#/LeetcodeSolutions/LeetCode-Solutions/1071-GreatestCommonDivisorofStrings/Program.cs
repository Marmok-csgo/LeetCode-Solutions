public class Solution
{
    public string GcdOfStrings(string str1, string str2)
    {
        if (str1.Length < str2.Length)
        {
            string temp = str1;
            str1 = str2;
            str2 = temp;
        }

        if (str1 == str2)
        {
            return str1;
        }

        if (str1.StartsWith(str2))
        {
            return GcdOfStrings(str1.Substring(str2.Length), str2);
        }

        return "";
    }
}