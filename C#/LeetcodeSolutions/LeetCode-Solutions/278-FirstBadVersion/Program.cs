public class Solution : VersionControl
{
    public int FirstBadVersion(int n)
    {
        int bad = 0;
        int low = 1;
        int high = n;
        while (low <= high)
        {
            int mid = low + (high - low) / 2;
            if (IsBadVersion(mid))
            {
                bad = mid;
                high = mid - 1;
            }
            else
                low = mid + 1;
        }
        return bad;
    }
}