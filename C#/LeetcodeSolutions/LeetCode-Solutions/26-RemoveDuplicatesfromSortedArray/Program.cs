public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        if (nums == null || nums.Length == 0)
        {
            return 0;
        }

        if (nums.Length == 1)
        {
            return 1;
        }

        int i = 0;
        for (int j = 1; j < nums.Length; j++)
        {
            if (nums[j] != nums[i])
            {
                i++;
                nums[i] = nums[j];
            }
        }

        return i + 1;
    }
}