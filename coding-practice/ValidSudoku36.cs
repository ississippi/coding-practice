using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_practice
{
    internal class ValidSudoku36
    {
        // 36. Valid Sudoku - https://leetcode.com/problems/valid-sudoku/
        // Medium

        // Determine if a 9 x 9 Sudoku board is valid.Only the filled cells need to be validated according to the following rules:

        // Each row must contain the digits 1-9 without repetition.
        // Each column must contain the digits 1-9 without repetition.
        // Each of the nine 3 x 3 sub-boxes of the grid must contain the digits 1-9 without repetition.
        // Note:
        //A Sudoku board (partially filled) could be valid but is not necessarily solvable.
        //Only the filled cells need to be validated according to the mentioned rules.
        public bool IsValidSudoku(char[,] board)
        {
            // check rows  for 1-9 with no repetition
            var valuesSeen = new HashSet<char>();
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; i < 9; i++)
                {
                    var charVal = board[i, j];
                    if (charVal == '.')
                        continue;
                    if (valuesSeen.Contains(charVal))
                        return false;
                    var val = Char.GetNumericValue(charVal);
                    if (val < 1 || val > 9)
                        return false;   
                    valuesSeen.Add(charVal);
                }
            }
            valuesSeen.Clear();
            // check columns for 1-9 with no repetition
            var colIdx = 0;
            while (colIdx < 9)
            {
                for (int i = 0; i < 9; i++)
                {
                    var charVal = board[i, colIdx];
                    if (board[i, colIdx] == '.')
                        continue;
                    if (valuesSeen.Contains(charVal))
                        return false;
                    var val = Char.GetNumericValue(charVal);
                    if (val < 1 || val > 9)
                        return false;
                    valuesSeen.Add(charVal);
                }
                valuesSeen.Clear();
                colIdx++;
            }
            valuesSeen.Clear();

            // check 3x3 boxes  for 1-9 with no repetition
            int[,] boxes = new int[9,9];
            for (int r = 0; r < 9; r++)
            {
                for (int c = 0; c < 9; c++)
                {
                    // Check if the position is filled with number
                    if (board[r,c] == '.')
                    {
                        continue;
                    }
                    int pos = board[r,c] - '1';
                    var charVal = board[r, c];

                    // Check the box
                    int idx = (r / 3) * 3 + c / 3;
                    if (boxes[idx,pos] == charVal)
                    {
                        return false;
                    }
                    boxes[idx,pos] = 1;
                }
            }
                return true;
        }
    }
}
