using System.Collections.Generic;

public class Solution
{
    public bool ContainsDuplicate(int[] nums)
    {
        HashSet<int> uniqueNums = new HashSet<int>();

        foreach (int num in nums)
        {
            if (uniqueNums.Contains(num))
            {
                return true;
            }
            uniqueNums.Add(num);
        }

        return false;
    }
}
