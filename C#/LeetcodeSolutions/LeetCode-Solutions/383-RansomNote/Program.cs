using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public bool CanConstruct(string ransomNote, string magazine)
    {
        var ransomNoteCounter = new Dictionary<char, int>();
        var magazineCounter = new Dictionary<char, int>();

        foreach (char c in ransomNote)
        {
            if (ransomNoteCounter.ContainsKey(c))
                ransomNoteCounter[c]++;
            else
                ransomNoteCounter[c] = 1;
        }

        foreach (char c in magazine)
        {
            if (magazineCounter.ContainsKey(c))
                magazineCounter[c]++;
            else
                magazineCounter[c] = 1;
        }

        foreach (var kvp in ransomNoteCounter)
        {
            if (!magazineCounter.ContainsKey(kvp.Key) || magazineCounter[kvp.Key] < kvp.Value)
                return false;
        }

        return true;
    }
}
