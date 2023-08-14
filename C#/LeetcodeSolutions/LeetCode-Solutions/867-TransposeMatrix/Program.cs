public class Solution {
    public int[][] Transpose(int[][] A) {
        int[][] res = new int[A[0].Length][];
        for (int i = 0; i < res.Length; i++)
            res[i] = new int[A.Length];
        for (int i = 0; i < A.Length; i++)
        {
            for (int j = 0; j < A[0].Length; j++)
                res[j][i] = A[i][j];
        }
        return res;
    }
}