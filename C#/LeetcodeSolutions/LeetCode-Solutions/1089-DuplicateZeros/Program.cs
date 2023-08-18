public class Solution {
    public void DuplicateZeros(int[] arr) {
        int countOfZeros = arr.Count(num => num == 0);
        int lastIndex = arr.Length + countOfZeros - 1;

        for (int i = arr.Length - 1; i >= 0; i--) {
            if (lastIndex < arr.Length) {
                arr[lastIndex] = arr[i];
            }
            lastIndex--;

            if (arr[i] == 0) {
                if (lastIndex < arr.Length) {
                    arr[lastIndex] = 0;
                }
                lastIndex--;
            }
        }
    }
}