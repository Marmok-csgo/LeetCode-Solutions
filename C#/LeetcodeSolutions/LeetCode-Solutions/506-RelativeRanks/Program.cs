using System;
using System.Collections.Generic;

public class Solution
{
    public string[] FindRelativeRanks(int[] score)
    {
        int[] sortedScores = (int[])score.Clone();
        Array.Sort(sortedScores, (a, b) => b.CompareTo(a));
        Dictionary<int, string> medalMapping = new Dictionary<int, string>
        {
            { 1, "Gold Medal" },
            { 2, "Silver Medal" },
            { 3, "Bronze Medal" }
        };

        string[] result = new string[score.Length];
        for (int i = 0; i < score.Length; i++)
        {
            int rank = Array.IndexOf(sortedScores, score[i]) + 1;
            if (medalMapping.ContainsKey(rank))
            {
                result[i] = medalMapping[rank];
            }
            else
            {
                result[i] = rank.ToString();
            }
        }

        return result;
    }
}