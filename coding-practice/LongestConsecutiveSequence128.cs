using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_practice
{
    // 128. Longest Consecutive Sequence - https://leetcode.com/problems/longest-consecutive-sequence/
    // Medium
    // Given an unsorted array of integers nums, return the length of the longest consecutive elements sequence.
    // You must write an algorithm that runs in O(n) time.

    // Example 1:
    // Input: nums = [100, 4, 200, 1, 3, 2]
    // Output: 4
    // Explanation: The longest consecutive elements sequence is [1, 2, 3, 4]. Therefore its length is 4.

    // Example 2:
    // Input: nums = [0, 3, 7, 2, 5, 8, 4, 6, 0, 1]
    // Output: 9



    internal class LongestConsecutiveSequence128
    {

        // Leetcode best - O(n)
        public int longestConsecutiveBest(int[] nums)
        {
            var num_set = new HashSet<int>();
            foreach (var num in nums)
            {
                num_set.Add(num);
            }

            int longestStreak = 0;

            foreach (var num in num_set)
            {
                if (!num_set.Contains(num - 1))
                {
                    int currentNum = num;
                    int currentStreak = 1;

                    while (num_set.Contains(currentNum + 1))
                    {
                        currentNum += 1;
                        currentStreak += 1;
                    }

                    longestStreak = Math.Max(longestStreak, currentStreak);
                }
            }

            return longestStreak;
        }

        // Leetcode Brute Force O(n3) - mine is faster
        private bool arrayContains(int[] arr, int num)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == num)
                {
                    return true;
                }
            }

            return false;
        }
        public int longestConsecutive(int[] nums)
        {
            int longestStreak = 0;

            foreach (var num in nums)
            {
                int currentNum = num;
                int currentStreak = 1;

                while (arrayContains(nums, currentNum + 1))
                {
                    currentNum += 1;
                    currentStreak += 1;
                }

                longestStreak = Math.Max(longestStreak, currentStreak);
            }

            return longestStreak;
        }

        // Mine O(nlgn): due to sort - Accepted
        public int LongestConsecutive(int[] nums)
        {
            if (nums.Length == 0)
                return 0;
            if (nums.Length == 1)
                return 1;
            var sortedNums = new SortedList<int, string>();
            foreach (int num in nums)
            {
                if (sortedNums.ContainsKey(num))
                    continue;
                sortedNums.Add(num, num.ToString());
            }
            if (sortedNums.Count == 1)
                return 1;
            var ctr = 0;
            var maxLength = Int32.MinValue;
            var prev = -1;
            foreach (var n in sortedNums)   
            {
                if (ctr == 0)
                {
                    prev = n.Key;
                    maxLength = ctr++;
                    continue;
                }
                if (n.Key == prev+1)
                {
                    ctr++;
                }
                else
                {
                    
                    ctr = 1;
                }
                if (ctr > maxLength)
                    maxLength = ctr;
                prev = n.Key;
            }
            return maxLength;
        }
    }
}
