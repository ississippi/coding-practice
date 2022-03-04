using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_practice
{
    internal class LengthOfLongestSubstring3
    {
        // 3. Longest Substring Without Repeating Characters - https://leetcode.com/problems/longest-substring-without-repeating-characters/
        // Medium
        // Given a string s, find the length of the longest substring without repeating characters.

        // Example 1:
        // Input: s = "abcabcbb"
        // Output: 3
        // Explanation: The answer is "abc", with the length of 3.
        // i = a, j = b, j = c, j = a = 3
        // i = b, j = c, j = a, j = b = 3
        // i = c, j = a, j = b, j = c = 3
        // i = a, j = b, j = c, j = b = 3
        // i = b, j = c, j = b = 2

        // Example 2:
        // Input: s = "bbbbb"
        // Output: 1
        // Explanation: The answer is "b", with the length of 1.

        // Example 3:
        // Input: s = "pwwkew"
        // Output: 3
        // Explanation: The answer is "wke", with the length of 3.

        // Notice that the answer must be a substring, "pwke" is a subsequence and not a substring.
        // Constraints:
        // 0 <= s.length <= 5 * 104
        // s consists of English letters, digits, symbols and spaces.
        public int LengthOfLongestSubstring(string s)
        {
            if (s.Length == 1)
                return 1;
            // sliding window
            var maxLen = 0;
            for(var i = 0; i < s.Length; i++)
            {
                for(var j = i+1; j < s.Length; j++)
                {
                    var currentSubstring = s.Substring(i, j-i);
                    if (s.Substring(i, j-i).Contains(s[j]))
                    {
                        if (j-i > maxLen)
                            maxLen = j-i;
                        break;
                    }
                    else
                    {
                        if (j - i > maxLen)
                            maxLen = j - i;
                    }

                }
            }
            return maxLen;
        }
    }
}
