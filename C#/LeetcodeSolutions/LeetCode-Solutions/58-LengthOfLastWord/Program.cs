public class Solution
{
    public int LengthOfLastWord(string s)
    {
        string[] words = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        if (words.Length > 0)
        {
            string lastWord = words[words.Length - 1];
            return lastWord.Length;
        }
        else
        {
            return 0;
        }
    }
}
