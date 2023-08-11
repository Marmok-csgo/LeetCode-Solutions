public class Solution
{
    public int[][] MatrixReshape(int[][] mat, int r, int c)
    {
        List<int> list1 = mat.SelectMany(row => row).ToList();
        List<int[]> matrix = new List<int[]>();

        if (mat.Length * mat[0].Length != r * c)
        {
            return mat;
        }

        for (int i = 0; i < list1.Count; i += c)
        {
            matrix.Add(list1.GetRange(i, Math.Min(c, list1.Count - i)).ToArray());
        }

        return matrix.ToArray();
    }
}