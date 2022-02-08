using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_practice
{
    internal class LongestSubstring
    {
        // Given a string s, find the length of the longest substring without repeating characters.
        // Input: s = "abcabcbb"
        // Output: 3
        // Explanation: The answer is "abc", with the length of 3.

        // Approach 1: Brute Force O(n^3)
        public int LengthOfLongestSubstringBruteForce(String s)
        {
            int n = s.Length;

            int res = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    if (checkRepetition(s, i, j))
                    {
                        res = Math.Max(res, j - i + 1);
                    }
                }
            }

            return res;
        }

        private bool checkRepetition(String s, int start, int end)
        {
            int[] chars = new int[128];

            for (int i = start; i <= end; i++)
            {
                char c = s[i];
                chars[c]++;
                if (chars[c] > 1)
                {
                    return false;
                }
            }

            return true;
        }

        // Approach 2: Sliding Window - O(2n)=O(n)
        public int LengthOfLongestSubstringSlidingWindow(String s)
        {
            var seen = new HashSet<int>();  
            int[] chars = new int[128];

            int left = 0;
            int right = 0;

            int res = 0;
            while (right < s.Length)
            {
                char r = s[right];
                seen.Add(r);
                chars[r]++;

                while (chars[r] > 1)
                {
                    char l = s[left];
                    chars[l]--;
                    left++;
                }

                res = Math.Max(res, right - left + 1);

                right++;
            }
            return res;
        }

        // Approach 3: Sliding Window Optimized - O(n)
        public int LengthOfLongestSubstringSlidingWindowOptimized(String s)
        {
            int n = s.Length, ans = 0;
            var map = new Dictionary<char, int>(); // current index of character
                                                            // try to extend the range [i, j]
            for (int j = 0, i = 0; j < n; j++)
            {
                if (map.ContainsKey(s[j]))
                {
                    i = Math.Max(map[s[j]], i);
                }
                ans = Math.Max(ans, j - i + 1);
                map.TryAdd(s[j], j + 1);
            }
            return ans;
        }
    }
}
