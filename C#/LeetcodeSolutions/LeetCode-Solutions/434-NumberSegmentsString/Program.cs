using System;

public class Solution
{
    public int CountSegments(string s)
    {
        string[] parts = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        return parts.Length;
    }
}
