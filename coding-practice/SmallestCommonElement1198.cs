using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_practice
{
    public static class SmallestCommonElement1198
    {
        // 1198. Find Smallest Common Element in All Rows
        // Medium
        // Given an m x n matrix mat where every row is sorted in strictly increasing order, return the smallest common element in all rows.
        // If there is no common element, return -1.

        // Example 1:
        // Input: mat = [[1, 2, 3, 4, 5], [2,4,5,8,10], [3,5,7,9,11], [1,3,5,7,9]]
        // Output: 5

        // Example 2:
        // Input: mat = [[1,2,3],[2,3,4],[2,3,5]]
        // Output: 2

        // O(n + M)
        public static int SmallestCommonElement(int[][] mat)
        {
            var common = new Dictionary<int, int>();
            var ans = Int32.MaxValue;

            for (int i = 0; i < mat.Length; i++)
            {
                for (var j = 0; j < mat[i].Length; j++)
                {
                    var key = mat[i][j];
                    if (!common.ContainsKey(key))
                    {
                        common.Add( key, 1);
                    }
                    else
                    {
                        common[key]++;
                    }
                }
            }
            foreach(var item in common)
            {
                if (item.Value < mat.Length)
                    continue;
                if (item.Key < ans)
                    ans = item.Key;
            }
            return (ans == Int32.MaxValue) ? -1: ans;
        }
    }
}
