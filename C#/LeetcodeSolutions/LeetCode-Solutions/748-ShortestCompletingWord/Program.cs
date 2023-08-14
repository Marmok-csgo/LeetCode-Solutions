public class Solution {
    public string ShortestCompletingWord(string licensePlate, string[] words) {
        string res = "";
        bool find = false;
        var dict = new Dictionary<char, int>();
        for (int i = 0; i < licensePlate.Length; i++)
        {
            var ch = licensePlate[i];
            if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
            {
                if (dict.ContainsKey(char.ToLower(ch)))
                    dict[char.ToLower(ch)]++;
                else dict[char.ToLower(ch)] = 1;
            }
        }
        for (int i = 0; i < words.Length; i++)
        {
            foreach(var item in dict)
            {
                if (words[i].Count(x => x == item.Key) < item.Value) 
                { find = false; break;}
                find = true;
            }
            if (find)
            {
                if (res == "") res = words[i];
                else if (words[i].Length < res.Length)
                    res = words[i];
            }
        }
        return res;
    }
}