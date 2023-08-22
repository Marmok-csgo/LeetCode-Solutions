public class Solution
{
    public int[] SmallerNumbersThanCurrent(int[] nums)
    {
        List<int> lst = new List<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            int count = 0;
            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[i] > nums[j])
                {
                    count++;
                }
            }
            lst.Add(count);
        }

        return lst.ToArray();
    }
}