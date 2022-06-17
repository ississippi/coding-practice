using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_practice
{

    internal class FindStringInMatrix79
    {
        //
        // 79. Word Search https://leetcode.com/problems/word-search/
        // Given an m x n grid of characters board and a string word, return true if word exists in the grid.
        // The word can be constructed from letters of sequentially adjacent cells,
        // where adjacent cells are horizontally or vertically neighboring.
        // The same letter cell may not be used more than once.
        // Examples:
        // Input: board = [["A","B","C","E"],["S","F","C","S"],["A","D","E","E"]], word = "ABCCED"
        // Output: true
        // Input: board = [["A","B","C","E"],["S","F","C","S"],["A","D","E","E"]], word = "SEE"
        // Output: true
        // Input: board = [["A","B","C","E"],["S","F","C","S"],["A","D","E","E"]], word = "ABCB"
        // Output: false
        //

        // Input: board = [["A","B","C","E"],["S","F","C","S"],["A","D","E","E"]], word = "SEE"
        // Output: true
        // https://leetcode.com/problems/word-search/
        
        // N rows, M columns
        // time complexity O(N x M x |word|^4)
        // space complexity O(N x M)
        public bool Exist(char[][] board, string word)
        {
            var visitedArr = new bool[board.Length, board[0].Length];

            // I need to call Explore for every item in the grid.
            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[0].Length; j++)
                {
                    if (Explore(i, j, word, 0, board, visitedArr) == true)
                        return true;
                }
            }
            return false;
        }

        private bool Explore(int row, int col, string word, int idxWord,
          char[][] board, bool[,] visited)
        {
            // Validate we are in the bounds of the grid.
            // ensure we are not negative as well.
            if (row >= board.Length || col >= board[0].Length ||
                row< 0 || col< 0)
                return false;

            // Exit with false if we have already visited this spot
            if (visited[row,col] == true)
                return false;

            // Exit with false if no match on the current character of the work
            // in this grid position
            if (word[idxWord] != board[row][col])
                return false;

            // if we are at the end of the word we have matched the word.
            if(idxWord == word.Length - 1)
                return true;

            // Mark the current row,col as visited.
            visited[row,col] = true;

            // Explore right
            if (Explore(row, col+1, word, idxWord+1, board, visited) == true)
                return true;
            // Explore left
            if (Explore(row, col-1, word, idxWord+1, board, visited) == true)
                return true;
            // Explore up
            if (Explore(row-1, col, word, idxWord+1, board, visited) == true)
                return true;
            // Explore down
            if (Explore(row+1, col, word, idxWord+1, board, visited) == true)
                return true;

            // Unmark the current row,col as visited.
            visited[row,col] = false;

            // We have failed to find a match.
            return false;
        }
    }
}
