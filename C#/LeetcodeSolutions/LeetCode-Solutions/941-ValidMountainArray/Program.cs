public class Solution {
    public bool ValidMountainArray(int[] arr) {
        int left = 0;
        int right = arr.Length - 1;

        while (left < right) {
            if (arr[left] < arr[left + 1]) {
                left++;
            } else if (arr[right - 1] > arr[right]) {
                right--;
            } else {
                break;
            }
        }

        return arr.Length >= 3 && 0 < left && left == right && right < arr.Length - 1;
    }
}