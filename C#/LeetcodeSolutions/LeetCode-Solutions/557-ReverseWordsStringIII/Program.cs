public class Solution
{
    public string ReverseWords(string s)
    {
        string[] words = s.Split();
        string[] reversedWords = new string[words.Length];

        for (int i = 0; i < words.Length; i++)
        {
            char[] wordChars = words[i].ToCharArray();
            Array.Reverse(wordChars);
            reversedWords[i] = new string(wordChars);
        }

        return string.Join(" ", reversedWords);
    }
}