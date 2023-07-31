public class Solution
{
    public int RemoveElement(int[] nums, int val)
    {
        int current = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != val)
            {
                nums[current] = nums[i];
                current++;
            }
        }
        return current;
    }
}