using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_practice
{
    // 1940. Longest Common Subsequence Between Sorted Arrays
    // Medium
    // Given an array of integer arrays arrays where each arrays[i] is sorted in strictly increasing order,
    // return an integer array representing the longest common subsequence between all the arrays.
    // A subsequence is a sequence that can be derived from another sequence by deleting some elements (possibly none) without changing the order of the remaining elements.

    // Example 1:
    // Input: arrays = [[1, 3, 4],
    //                 [1,4,7,9]]
    // Output: [1,4]
    // Explanation: The longest common subsequence in the two arrays is [1,4].

    // Example 2:
    // Input: arrays = [[2,3,6,8],
    //                 [1,2,3,5,6,7,10],
    //                 [2,3,4,6,9]]
    // Output: [2,3,6]
    // Explanation: The longest common subsequence in all three arrays is [2,3,6].

    // Example 3:
    // Input: arrays = [[1,2,3,4,5],
    //                 [6,7,8]]
    // Output: []
    // Explanation: There is no common subsequence between the two arrays.
    internal class LongestCommonSubsequence1940
    {

        public IList<int> LongestCommonSubsequence(int[][] arrays)
        {
            var ans = new List<int>();
            var seenCount = new Dictionary<int, int>();

            for (int i = 0; i < arrays.Length; i++)
            {
                for (int j = 0; j < arrays[i].Length; j++)
                {
                    var key = arrays[i][j];
                    if (!seenCount.ContainsKey(key))
                    {
                        seenCount.Add(key, 1);
                    }
                    else
                    {
                        seenCount[key]++;
                    }
                }
            }
            foreach (var item in seenCount)
            {
                if(item.Value == arrays.Length)
                { 
                    ans.Add(item.Key);
                }
            }
            ans.Sort();
            return ans;

        }


    }
}
