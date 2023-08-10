public class Solution {
    static string[] _rows = new string[]
    {
        "qwertyuiop",
        "asdfghjkl",
        "zxcvbnm",
    };
    public string[] FindWords(string[] words)
        => words.Where(w => _rows.Any(l => w.ToLower().All(c => l.Contains(c)))).ToArray();
}