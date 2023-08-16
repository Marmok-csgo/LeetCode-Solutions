using System;
using System.Collections.Generic;

public class Solution
{
    public int NumRookCaptures(char[][] board)
    {
        int[][] directions = new int[][] { new int[] { -1, 0 }, new int[] { 1, 0 }, new int[] { 0, -1 }, new int[] { 0, 1 } };
        int x = 0, y = 0;
        bool found = false;

        for (int i = 0; i < board.Length; i++)
        {
            for (int j = 0; j < board[0].Length; j++)
            {
                if (board[i][j] == 'R')
                {
                    x = i;
                    y = j;
                    found = true;
                    break;
                }
            }

            if (found)
                break;
        }

        int count = 0;
        foreach (var dir in directions)
        {
            int dx = dir[0];
            int dy = dir[1];

            int newRow = x + dx;
            int newCol = y + dy;

            while (newRow >= 0 && newRow < 8 && newCol >= 0 && newCol < 8)
            {
                if (board[newRow][newCol] == 'p')
                {
                    count++;
                    break;
                }
                else if (board[newRow][newCol] == 'B')
                {
                    break;
                }

                newRow += dx;
                newCol += dy;
            }
        }

        return count;
    }
}