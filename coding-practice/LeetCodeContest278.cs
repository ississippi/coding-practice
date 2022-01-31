using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_practice
{
    internal class LeetCodeContest278
    {
        //5993. Keep Multiplying Found Values by Two
        //Input: nums = [5,3,6,1,12], original = 3
        //Output: 24
        //Explanation: 
        //- 3 is found in nums. 3 is multiplied by 2 to obtain 6.
        //- 6 is found in nums. 6 is multiplied by 2 to obtain 12.
        //- 12 is found in nums. 12 is multiplied by 2 to obtain 24.
        //- 24 is not found in nums.Thus, 24 is returned.

        public int FindFinalValue(int[] nums, int original)
        {
            var sum = original;
            var found = true;
            while (found)
            {
                found = false;
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] == sum)
                    {
                        found = true;
                        sum = nums[i] * 2;
                        break;
                    }
                }
            }
            return sum;
        }
        //5981. All Divisions With the Highest Score of a Binary Array

        //User Accepted:4206
        //User Tried:4896
        //Total Accepted:4244
        //Total Submissions:5970
        //Difficulty:Medium
        //You are given a 0-indexed binary array nums of length n.nums can be divided at index i(where 0 <= i <= n) into two arrays(possibly empty) numsleft and numsright:

        //numsleft has all the elements of nums between index 0 and i - 1 (inclusive), while numsright has all the elements of nums between index i and n - 1 (inclusive).
        //If i == 0, numsleft is empty, while numsright has all the elements of nums.
        //If i == n, numsleft has all the elements of nums, while numsright is empty.
        //The division score of an index i is the sum of the number of 0's in numsleft and the number of 1's in numsright.

        //Return all distinct indices that have the highest possible division score.You may return the answer in any order.
        //Input: nums = [0,0,1,0]
        //Output: [2,4]
        //Explanation: Division at index
        //- 0: numsleft is []. numsright is [0,0,1,0]. The score is 0 + 1 = 1.
        //- 1: numsleft is [0]. numsright is [0,1,0]. The score is 1 + 1 = 2.
        //- 2: numsleft is [0,0]. numsright is [1,0]. The score is 2 + 1 = 3.
        //- 3: numsleft is [0,0,1]. numsright is [0]. The score is 2 + 0 = 2.
        //- 4: numsleft is [0,0,1,0]. numsright is []. The score is 3 + 0 = 3.
        //Indices 2 and 4 both have the highest possible division score 3.
        //Note the answer[4, 2] would also be accepted.
        public IList<int> MaxScoreIndices(int[] nums)
        {
            var maxScore = 0;
            var score = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                var rightLen = nums.Length - i;
                var leftLen = nums.Length - rightLen;

            }

            return null;
        }

        //5994. Find Substring With Given Hash Value
        //User Accepted:300
        //User Tried:1487
        //Total Accepted:302
        //Total Submissions:2336
        //Difficulty:Medium
        //The hash of a 0-indexed string s of length k, given integers p and m, is computed using the following function:

        //hash(s, p, m) = (val(s[0])* p0 + val(s[1]) * p1 + ... + val(s[k - 1]) * pk-1) mod m.
        // Where val(s[i]) represents the index of s[i] in the alphabet from val('a') = 1 to val('z') = 26.

        //You are given a string s and the integers power, modulo, k, and hashValue.Return sub, the first substring of s of length k such that hash(sub, power, modulo) == hashValue.

        //The test cases will be generated such that an answer always exists.

        //A substring is a contiguous non-empty sequence of characters within a string.
        //Example 1:

        //Input: s = "leetcode", power = 7, modulo = 20, k = 2, hashValue = 0
        //Output: "ee"
        //Explanation: The hash of "ee" can be computed to be hash("ee", 7, 20) = (5 * 1 + 5 * 7) mod 20 = 40 mod 20 = 0. 
        //"ee" is the first substring of length 2 with hashValue 0. Hence, we return "ee".
        //Example 2:

        //Input: s = "fbxzaad", power = 31, modulo = 100, k = 3, hashValue = 32
        //Output: "fbx"
        //Explanation: The hash of "fbx" can be computed to be hash("fbx", 31, 100) = (6 * 1 + 2 * 31 + 24 * 312) mod 100 = 23132 mod 100 = 32. 
        //The hash of "bxz" can be computed to be hash("bxz", 31, 100) = (2 * 1 + 24 * 31 + 26 * 312) mod 100 = 25732 mod 100 = 32. 
        //"fbx" is the first substring of length 3 with hashValue 32. Hence, we return "fbx".
        //Note that "bxz" also has a hash of 32 but it appears later than "fbx".
        public string SubStrHash(string s, int power, int modulo, int k, int hashValue)
        {
            return String.Empty;
        }

        //5995. Groups of Strings
        //User Accepted:36
        //User Tried:173
        //Total Accepted:37
        //Total Submissions:349
        //Difficulty:Hard
        //You are given a 0-indexed array of strings words.Each string consists of lowercase English letters only.No letter occurs more than once in any string of words.

        //Two strings s1 and s2 are said to be connected if the set of letters of s2 can be obtained from the set of letters of s1 by any one of the following operations:

        //Adding exactly one letter to the set of the letters of s1.
        //Deleting exactly one letter from the set of the letters of s1.
        //Replacing exactly one letter from the set of the letters of s1 with any letter, including itself.
        //The array words can be divided into one or more non-intersecting groups. A string belongs to a group if any one of the following is true:

        //It is connected to at least one other string of the group.
        //It is the only string present in the group.
        //Note that the strings in words should be grouped in such a manner that a string belonging to a group cannot be connected to a string present in any other group.It can be proved that such an arrangement is always unique.

        //Return an array ans of size 2 where:

        //ans[0] is the total number of groups words can be divided into, and
        //ans[1] is the size of the largest group.

        //Example 1:

        //Input: words = ["a","b","ab","cde"]
        //        Output: [2,3]
        //        Explanation:
        //- words[0] can be used to obtain words[1] (by replacing 'a' with 'b'), and words[2] (by adding 'b'). So words[0] is connected to words[1] and words[2].
        //- words[1] can be used to obtain words[0] (by replacing 'b' with 'a'), and words[2] (by adding 'a'). So words[1] is connected to words[0] and words[2].
        //- words[2] can be used to obtain words[0] (by deleting 'b'), and words[1] (by deleting 'a'). So words[2] is connected to words[0] and words[1].
        //- words[3] is not connected to any string in words.
        //Thus, words can be divided into 2 groups["a", "b", "ab"] and["cde"]. The size of the largest group is 3.  
        //Example 2:

        //Input: words = ["a","ab","abc"]
        //        Output: [1,3]
        //        Explanation:
        //- words[0] is connected to words[1].
        //- words[1] is connected to words[0] and words[2].
        //- words[2] is connected to words[1].
        //Since all strings are connected to each other, they should be grouped together.
        //Thus, the size of the largest group is 3.
        public int[] GroupStrings(string[] words)
        {
            return null;
        }
    }
}
