using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_practice
{
    internal class IsWordInGrid
    {
    }

    // To execute C#, please define "static void Main" on a class
    // named Solution.

    /*

    You are given a target word and a MxN grid that contains lowercase letters.

    Your goal is to return true or false if that word exists in the grid.

    A word in the grid can be constructed by connecting adjacent cells that are vertically or horizontally.

    The same letter cell cannot be used more than once.


    a b c d
    a a g h
    c d e f

    target_word = "bagh" output = True
    target_word = "bagha" output = False
    target_word = "badd" output = False
    target_word = "bad" output = True

    target_word = "hga" output = True
    target_word = "fhd" output = True


    */

    // check this site out: pramp.com
    //class Solution
    //    {
    //        static void Main(string[] args)
    //        {
    //            char[,] grid1 = new char[,] {{'a','b','c','d'}
    //                                     ,{'a','a','g','h'}
    //                                     ,{'c','d','e','f'}};

    //            Console.WriteLine("Result: " + isWordInGrid("bagh", grid1));
    //        }

    //        public bool isWordInGrid(string target, char[,] grid)
    //        {
    //            char[] word = target.ToCharArray();
    //            int workIdx = 0;
    //            // rows
    //            for (int i = 0; i < grid.Length; i++)
    //            {
    //                for (int j = 0; j < grid[i].Length; j++)
    //                {

    //                    // to prevent premature termination      
    //                    if (helper(grid, i, j, 0, word))
    //                    {
    //                        return true;
    //                    }
    //                }
    //            }

    //            return false;
    //        }

    //        public bool helper(char[,] grid, int i, int j, int wordIdx, char[] word, bool[,] visited)
    //        {
    //            // base condition
    //            if (wordIdx == word.Length - 1)
    //                return true;

    //            if (i < 0 || i > grid.Length || j < 0 || j > grid[0].Length)
    //            {
    //                return false;
    //            }

    //            if (word[wordIdx] != grid[i,j])
    //            {
    //                return false;
    //            }

    //            if (visited[i,j])
    //            {
    //                return false;
    //            }

    //            visited[i,j] = true;

    //            if (helper(grid, i, j + 1, wordIdx + 1, word) // right 
    //                || helper(grid, i, j - 1, wordIdx + 1, word) //left
    //                || helper(grid, i + 1, j, wordIdx + 1, word)  // down
    //                || helper(grid, i - 1, j, wordIdx + 1, word) // up
    //                )
    //            {

    //                return true;
    //            }

    //            return false;
    //        }
    //    }

    //}
}
