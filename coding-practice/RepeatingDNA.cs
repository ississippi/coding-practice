using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_practice
{
    internal class RepeatingDNA
    {
        // 187. Repeated DNA Sequences https://leetcode.com/problems/repeated-dna-sequences/
        // Medium
        // The DNA sequence is composed of a series of nucleotides abbreviated as 'A', 'C', 'G', and 'T'.
        // For example, "ACGAATTCCG" is a DNA sequence.
        // When studying DNA, it is useful to identify repeated sequences within the DNA.
        // Given a string s that represents a DNA sequence, return all the 10-letter-long sequences (substrings) that occur more than once in a DNA molecule.You may return the answer in any order.

        // Example 1:
        // Input: s = "AAAAACCCCCAAAAACCCCCCAAAAAGGGTTT"
        // Output: ["AAAAACCCCC","CCCCCAAAAA"]

        // Example 2:
        // Input: s = "AAAAAAAAAAAAA"
        // Output: ["AAAAAAAAAA"]
        public IList<string> FindRepeatedDnaSequencesOptimal(string s)
        {
            // Compare 1st 10 chars, advancing one char at a time
            // Put every 10 char string into a seen hashset
            // First check seen hashset before the next char in the array
            // Add to the result string array when a match on seen hashset
            var result = new HashSet<string>();
            var seen = new HashSet<string>();

            for (var i = 0; i < s.Length - 9; i++)
            {
                var currentDNA = s.Substring(i, 10);
                if (!seen.Add(currentDNA))
                {
                    result.Add(currentDNA);
                }
            }
            return result.ToArray();
        }

        public IList<string> FindRepeatedDnaSequencesNoGood(string s)
        {
            // Compare 1st 10 chars, advancing one char at a time
            // Put every 10 char string into a seen hashset
            // First check seen hashset before the next char in the array
            // Add to the result string array when a match on seen hashset
            var result = new HashSet<string>();
            var currentDNA = string.Empty;

        for (var i = 0; i < s.Length - 10; i++)
            {
                currentDNA = s.Substring(i, 10);
                for (var j = i; j < s.Length - 10; j++)
                {
                    if (currentDNA == s.Substring(j, 10))
                    {
                        result.Add(currentDNA);
                        break;
                    }
                }
            }
            return result.ToArray();
        }
    }
}

        //    Input
        //"AAAAAAAAAAA"
        //Output
        //[]
        //Expected
        //["AAAAAAAAAA"]

        //// O(n^2)
        //for (int i=0; i<n;i ++) {
        //  for (int j=0; j<n;j++) {
        //    // do something - singular
        //  }
        //}

        //// n^2/2
        //// O(n^2)
        //for (int i = 0; i < n; i++)
        //{
        //    for (int j = 0; j < n / 2; j++)
        //    {
        //        // do something - singular
        //    }
        //}

        //// n^2/2
        //// O(n^2)
        //for (int i = 0; i < n; i++)
        //{
        //    for (int j = i; j < n; j++)
        //    {
        //        // do something - singular
        //    }
        //}
