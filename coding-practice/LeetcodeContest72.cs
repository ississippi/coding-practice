using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_practice
{
    internal class LeetcodeContest72
    {
        //
        // 2176. Count Equal and Divisible Pairs in an Array https://leetcode.com/contest/biweekly-contest-72/problems/count-equal-and-divisible-pairs-in-an-array/
        // Easy
        // Solved
        public int CountPairs(int[] nums, int k)
        {
            var pairCount = 0;
            var numLen = nums.Length;
            for (var i = 0; i < numLen; i++)
            {
                for(var j = i+1; j < numLen; j++)
                {
                    var num1 = nums[i];
                    var num2 = nums[j];
                    if (num1 == num2)
                    {
                         if ((i * j) % k == 0)
                        {
                            pairCount++;
                        }
                    }
                }
            }
            return pairCount;

        }
        //
        // 2177. Find Three Consecutive Integers That Sum to a Given Number https://leetcode.com/contest/biweekly-contest-72/problems/find-three-consecutive-integers-that-sum-to-a-given-number/
        // Medium
        // Solved!
        public long[] SumOfThree(long num)
        {
            long num1 = num/3 - 1;
            long num2 = num1+1;
            long num3 = num2+1;
            var results = new List<long>();
            var sumOfThree = num1 + num2 + num3;

            while (sumOfThree <= num)
            {
                if (sumOfThree == num)
                {
                    results.Add(num1);
                    results.Add(num2);
                    results.Add(num3);
                    return results.ToArray();   
                }
                else
                {
                    num1 += 1;
                    num2 += 1;
                    num3 += 1;
                }
                sumOfThree = num1 + num2 + num3;
            }
            return results.ToArray();
        }
        //
        // 2178. Maximum Split of Positive Even Integers https://leetcode.com/contest/biweekly-contest-72/problems/maximum-split-of-positive-even-integers/
        // Medium
        // NOT Solved!
        // My Solution:
        public IList<long> MaximumEvenSplit2178(long finalSum)
        {
            var results = new List<long>();
            if (finalSum % 2 != 0)
                return results;
            var num = finalSum / 2;
            results.Add(num);
            while (true)
            {
                num = num - 2;
                if (num <= 0)
                    return null;
                if (GetCurrentSum(results) + num > finalSum)
                    continue;
                results.Add(num);
                if (GetCurrentSum(results) == finalSum)
                    return results.ToArray();
            }
            return results.ToArray();
        }
        public long GetCurrentSum(List<long> results)
        {
            long sum = 0;
            foreach (var n in results)
            {
                sum += n;
            }
            return sum;
        }

        //
        // 2178. Maximum Split of Positive Even Integers https://leetcode.com/contest/biweekly-contest-72/problems/maximum-split-of-positive-even-integers/
        // Leetcode Community Solution - https://leetcode.com/problems/maximum-split-of-positive-even-integers/discuss/1783191/C%2B%2B-or-Easy-Simulation-or-O(MaximumNumbers)-Time-and-O(1)-Space
        // So it's clear from question that if n is odd answer is not possible (bcz we can't represent a odd number as a sum of even numbers)
        // Now if n is even , then we have to make the largest list of unique even number such that the sum is equal to given n.
        // Now to make the largest we have to take smallest numbers first like 2,4,6,8... and so on.
        // but wait what happen if we are doing in this manner and the total sum is greater than desired , no worries,
        // we wll do this step untill our sum is less than or equal to given number , and just add the remaining difference to last number in the list.
        // Take n = 14
        // i = 2, crSum = 0, list = [](crSum + 2 <= 14, so push it), crSum + i = 2, list = [2]
        // i = 4, crSum = 2, list = [2](crSum + 4 <= 14, so push it), crSum + i = 6, list = [2, 4]
        // i = 6, crSum = 6, list = [2, 4](crSum + 6 <= 14, so push it), crSum + i = 12, list = [2, 4, 6]
        // i = 8, crSum = 12, list = [2, 4, 6](crSum + 8 > 14, so don't push it , break the loop)
        // Now we have crSum = 12, and we want 14, so simply add difference(which is 14 - 12 = 2) in the last element of list
        // so list = [2, 4, 6 + (14 - 12)] = [2, 4, 8]
        //

        // Time: ??? Space () ???
        public List<long> MaximumEvenSplit(long n)
        {
            var ans = new List<long>();
            if (n % 2 != 0) // odd
                return ans;

            long i = 2;
            long crSum = 0;

            while ((crSum + i) <= n)
            {
                ans.Add(i);
                crSum += i;
                i += 2;
            }

            // add remaining difference to the last value in answer list
            int sz = ans.Count;
            ans[sz - 1] += (n - crSum);
            return ans;
        }
    }
}
