using System;
using System.Collections.Generic;

public class Solution
{
    public int ThirdMax(int[] nums)
    {
        HashSet<int> distinctNumbers = new HashSet<int>(nums);
        List<int> uniqueNumbers = new List<int>(distinctNumbers);

        if (uniqueNumbers.Count == 1)
        {
            return uniqueNumbers[0];
        }
        else if (uniqueNumbers.Count == 2)
        {
            uniqueNumbers.Sort();
            return uniqueNumbers[1];
        }
        else
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < uniqueNumbers.Count - 1; j++)
                {
                    if (uniqueNumbers[j] > uniqueNumbers[j + 1])
                    {
                        int temp = uniqueNumbers[j];
                        uniqueNumbers[j] = uniqueNumbers[j + 1];
                        uniqueNumbers[j + 1] = temp;
                    }
                }
            }
            return uniqueNumbers[uniqueNumbers.Count - 3];
        }
    }
}
