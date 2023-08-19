public class Solution {
    public IList<IList<int>> ShiftGrid(int[][] grid, int k) {
        IList<IList<int>> retVal = new List<IList<int>>();
        
        k = k % (grid.Length * grid[0].Length);
        
        for (int i = 0; i < grid.Length; ++i)
        {
            List<int> newRow = new List<int>();
            retVal.Insert(i, newRow);
            for (int j = 0; j < grid[0].Length; ++j)            
                newRow.Insert(j, 0);            
        }
                    
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[0].Length; ++j)
            {   
                int distFromZero = i * grid[0].Length + j; 
                int shiftTo = (distFromZero + k) % (grid.Length * grid[0].Length); 
                int newRow = shiftTo / grid[0].Length;
                int newCol = shiftTo % grid[0].Length;
                retVal[newRow][newCol] = grid[i][j];                                
            }
        }
        return retVal;
    }
}