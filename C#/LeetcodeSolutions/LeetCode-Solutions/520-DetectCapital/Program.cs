public class Solution
{
    public bool DetectCapitalUse(string word)
    {
        if (IsAllUpperCase(word) || IsAllLowerCase(word) || IsTitleCase(word))
        {
            return true;
        }
        return false;
    }

    private bool IsAllUpperCase(string str)
    {
        return str == str.ToUpper();
    }

    private bool IsAllLowerCase(string str)
    {
        return str == str.ToLower();
    }

    private bool IsTitleCase(string str)
    {
        if (string.IsNullOrEmpty(str))
        {
            return false;
        }

        bool isFirstUpperCase = char.IsUpper(str[0]);
        bool isRestLowerCase = true;

        for (int i = 1; i < str.Length; i++)
        {
            if (char.IsUpper(str[i]))
            {
                isRestLowerCase = false;
                break;
            }
        }

        return isFirstUpperCase && isRestLowerCase;
    }
}