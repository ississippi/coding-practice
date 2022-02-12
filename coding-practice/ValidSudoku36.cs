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

        //
        // Solution Algorithm from Leetcode for me to implement in code
        //
        public bool IsValidSudoku(char[,] board)
        {
            // ==============================================================================================================================================
            // Initialize a list containing 9 hash sets, where the hash set at index r will be used to store previously seen numbers in row r of the sudoku.
            // Likewise, initialize lists of 9 hash sets to track the columns and boxes too.
            // Iterate over each position(r, c) in the sudoku.At each iteration, if there is a number at the current position:
            // Check if the number exists in the hash set for the current row, column, or box.
            // If it does, return false, because this is the second occurrence of the number in the current row, column, or box.
            // Otherwise, update the set responsible for tracking previously seen numbers in the current row, column, and box.
            // The index of the current box is (r / 3) * 3 + (c / 3) where / represents floor division.
            // If no duplicates were found after every position on the sudoku board has been visited, then the sudoku is valid, so return true.
            // ==============================================================================================================================================
            var seenList = new List<HashSet<int>>();


            return false;
        }


        // My solution - 2/3 complete. works for vertical and horizontal but not for 3x3 grids.
        public bool IsValidSudokuOLD(char[,] board)
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
