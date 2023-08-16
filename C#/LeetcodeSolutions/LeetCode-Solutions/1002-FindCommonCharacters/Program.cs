using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public IList<string> CommonChars(string[] A)
    {
        Dictionary<char, int> res = new Dictionary<char, int>();
        foreach (char c in A[0])
        {
            if (res.ContainsKey(c))
            {
                res[c]++;
            }
            else
            {
                res[c] = 1;
            }
        }
        
        foreach (string a in A)
        {
            Dictionary<char, int> temp = new Dictionary<char, int>();
            foreach (char c in a)
            {
                if (temp.ContainsKey(c))
                {
                    temp[c]++;
                }
                else
                {
                    temp[c] = 1;
                }
            }
            
            foreach (var kvp in res.ToList())
            {
                if (temp.ContainsKey(kvp.Key))
                {
                    res[kvp.Key] = Math.Min(res[kvp.Key], temp[kvp.Key]);
                }
                else
                {
                    res.Remove(kvp.Key);
                }
            }
        }
        
        List<string> result = new List<string>();
        foreach (var kvp in res)
        {
            for (int i = 0; i < kvp.Value; i++)
            {
                result.Add(kvp.Key.ToString());
            }
        }
        
        return result;
    }
}