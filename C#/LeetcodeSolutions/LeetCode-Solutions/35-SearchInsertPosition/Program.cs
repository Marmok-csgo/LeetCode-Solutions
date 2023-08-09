public class Solution
{
    public int SearchInsert(int[] nums, int target)
    {
        var index = Array.BinarySearch(nums, target);
        return index >= 0 ? index : ~index;
    }
}