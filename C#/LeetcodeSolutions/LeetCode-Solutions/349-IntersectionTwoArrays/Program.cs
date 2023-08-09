public class Solution
{
    public int[] Intersection(int[] nums1, int[] nums2)
    {
        HashSet<int> result = new HashSet<int>(nums2);
        result.IntersectWith(nums1);
        return result.ToArray();
    }
}