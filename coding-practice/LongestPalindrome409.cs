using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_practice
{
    internal class LongestPalindrome409
    {

        public int myLongestPalindrome(string s)
        {
            if (s.Length == 1)
                return 1;
            var letterCounts = new Dictionary<char, int>();
            var sum = 0;
            foreach (var c in s)
            {
                if(letterCounts.ContainsKey(c))
                    letterCounts[c]++;
                else
                    letterCounts.Add(c, 1);
            }
            var foundASingle = false;
            if(letterCounts.Count == 1)
            {
                foreach(var c in letterCounts)
                {
                    return c.Value;
                }
            }
            foreach(var c in letterCounts)
            {
                if(c.Value % 2 == 0)
                {
                    sum += c.Value;
                }
                else
                {
                    if (c.Value > 1)
                        sum += c.Value - 1;
                    else if (c.Value == 1 && foundASingle == false)
                    {
                        sum += 1;
                        foundASingle = true;
                    }
                }
            }
            return sum;
        }

        // Approach #1: Greedy [Accepted]
        // Intuition
        // A palindrome consists of letters with equal partners, plus possibly a unique center(without a partner).
        // The letter i from the left has its partner i from the right.
        // For example in 'abcba', 'aa' and 'bb' are partners, and 'c' is a unique center.
        // Imagine we built our palindrome.It consists of as many partnered letters as possible,
        // plus a unique center if possible.This motivates a greedy approach.
        // Algorithm
        // For each letter, say it occurs v times.We know we have v // 2 * 2 letters that can be partnered for sure.
        // For example, if we have 'aaaaa', then we could have 'aaaa' partnered, which is 5 // 2 * 2 = 4 letters partnered.
        // At the end, if there was any v % 2 == 1, then that letter could have been a unique center.Otherwise,
        // every letter was partnered. To perform this check, we will check for v % 2 == 1 and ans % 2 == 0,
        // the latter meaning we haven't yet added a unique center to the answer.
        public int LongestPalindrome(String s)
        {
            if (s.Length == 1)
                return 1;
            var letterCounts = new Dictionary<char, int>();
            var sum = 0;
            foreach (var c in s)
            {
                if (letterCounts.ContainsKey(c))
                    letterCounts[c]++;
                else
                    letterCounts.Add(c, 1);
            }

            int ans = 0;
            // this does not appear to work and more than 1 unpartnered character
            foreach (var v in letterCounts.Values)
            {
                ans += v / 2 * 2; // this is like a Math.Floor for odd numbers.
                if (ans % 2 == 0 && v % 2 == 1) 
                    ans++;
            }
            return ans;
        }
    }
}
