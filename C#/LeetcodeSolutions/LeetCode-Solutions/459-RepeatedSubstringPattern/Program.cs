using System;

public class Solution
{
    public bool RepeatedSubstringPattern(string s)
    {
        string doubledS = s + s;
        doubledS = doubledS.Substring(1, doubledS.Length - 2);
        return doubledS.Contains(s);
    }
}
