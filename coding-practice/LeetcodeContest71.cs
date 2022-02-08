using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_practice
{
    internal class LeetcodeContest71
    {
        // Question 1 - Easy
        // 2160. Minimum Sum of Four Digit Number After Splitting Digits
        // User Accepted:7839
        // User Tried:8174
        // Total Accepted:8121
        // Total Submissions:9611
        // Difficulty:Easy
        // You are given a positive integer num consisting of exactly four digits.
        // Split num into two new integers new1 and new2 by using the digits found in num.
        // Leading zeros are allowed in new1 and new2, and all the digits found in num must be used.
        // For example, given num = 2932, you have the following digits: two 2's, one 9 and one 3. Some of the possible pairs [new1, new2] are [22, 93], [23, 92], [223, 9] and [2, 329].
        // Return the minimum possible sum of new1 and new2.

        //Example 1:
        //Input: num = 2932
        //Output: 52
        //Explanation: Some possible pairs[new1, new2] are [29, 23], [223, 9], etc.
        //The minimum sum can be obtained by the pair[29, 23]: 29 + 23 = 52.

        //Example 2:
        //Input: num = 4009
        //Output: 13
        //Explanation: Some possible pairs[new1, new2] are [0, 49], [490, 0], etc.
        //The minimum sum can be obtained by the pair[4, 9]: 4 + 9 = 13.

        //public int MinimumSum(int num)
        //{
        //    var smallestSum = Int32.MaxValue;
        //    var numStr = num.ToString();
        //    var num1 = string.Empty;
        //    var num2 = string.Empty;
        //    List<int> lengths = new List<int>();
        //    for (int i = 1; i < numStr.Length; i++)
        //    {
        //        lengths.Add(numStr.Length - (i));
        //    }
        //    for (int i = 0; i < numStr.Length-1; i++)
        //    {
        //        for (int j = i+1; j < numStr.Length; j++)
        //        {
        //            Console.Write(numStr[i] + numStr[j]);
        //            //for (var k = 0; k < lengths.Count; k++)
        //            //{
        //            //    var num1Len = lengths[k];
        //            //    var num2Len = numStr.Length - num1Len;   
        //            //}
        //        }
        //        //var num2Len = numStr.Length - (i + 1);
        //        //var num1Len = numStr.Length - num2Len;
        //        //num1 = numStr.Substring(i, num1Len);
        //        //num2 = numStr.Substring(i + 1, num2Len);
        //        //var newSum = Int32.Parse(num1) + Int32.Parse(num2);
        //        //smallestSum = (smallestSum > newSum) ? newSum : smallestSum;   
        //    }
        //    return smallestSum;
        //}

        // Sample solution from a contest participant below. Original code was in C++
        // His explanation:
        // the vector n stores all the digits individually, then it is sorted in ascending order.
        // now for minimum sum the numbers are formed as such :
        // e.g.num = 4009
        // n = [0, 0, 4, 9] after sorting
        // ...n[0] * 10 + n[2] --> 0 * 10 + 4 -> 4
        // +..n[1] * 10 + n[3] --> 0 * 10 + 9 -> 9
        // ...........................................................13 !!!

    public int MinimumSum1(int num)
        {

            List<int> n = new List<int>();

            // this marches through each digit in the 4 digit number and adds to an array.
            // 1. modulus to get the last digit
            // 2. divide by 10 removing the last digit just added to the array.
            n.Add(num % 10);
            num = num / 10;
            n.Add(num % 10);
            num = num / 10;
            n.Add(num % 10);
            num = num / 10;
            n.Add(num % 10);

            n.Sort(); // smallest numbers to biggest

            return ((n[0] * 10) + n[2] + (n[1] * 10) + n[3]);
        }

        // Here's another sample solution. This one was in Java
        public int MinimumSum2(int num)
        {
            List<int> dig = new List<int>(); // For each digit
            //int cur = 0;
            while (num > 0) // Getting each digit
            {
                //dig[cur++] = num % 10;
                dig.Add(num % 10);
                num /= 10;
            }
            dig.Sort(); // Ascending order
            int num1 = dig[0] * 10 + dig[2]; // 1st and 3rd digit
            int num2 = dig[1] * 10 + dig[3]; // 2nd and 4th digit
            return num1 + num2;
        }

        // Question 2 - Medium
        // 2161. Partition Array According to Given Pivot
        // User Accepted:7313
        // User Tried:7830
        // Total Accepted:7510
        // Total Submissions:9728
        // Difficulty:Medium
        // You are given a 0-indexed integer array nums and an integer pivot.Rearrange nums such that the following conditions are satisfied:

        // Every element less than pivot appears before every element greater than pivot.
        // Every element equal to pivot appears in between the elements less than and greater than pivot.
        // The relative order of the elements less than pivot and the elements greater than pivot is maintained.
        // More formally, consider every pi, pj where pi is the new position of the ith element and pj is the new position of the jth element.
        // For elements less than pivot, if i<j and nums[i] < pivot and nums[j] < pivot, then pi<pj.Similarly for elements greater than pivot,
        // if i<j and nums[i]> pivot and nums[j]> pivot, then pi<pj.
        // Return nums after the rearrangement.

        //Example 1:
        //Input: nums = [9, 12, 5, 10, 14, 3, 10], pivot = 10
        //Output: [9, 5, 3, 10, 10, 12, 14]
        //Explanation: 
        //The elements 9, 5, and 3 are less than the pivot so they are on the left side of the array.
        //The elements 12 and 14 are greater than the pivot so they are on the right side of the array.
        //The relative ordering of the elements less than and greater than pivot is also maintained. [9, 5, 3] and[12, 14] are the respective orderings.
        //Example 2:

        //Input: nums = [-3, 4, 3, 2], pivot = 2
        //Output: [-3,2,4,3]
        //Explanation: 
        //The element -3 is less than the pivot so it is on the left side of the array.
        //The elements 4 and 3 are greater than the pivot so they are on the right side of the array.
        //The relative ordering of the elements less than and greater than pivot is also maintained. [-3] and[4, 3] are the respective orderings.

        // My solution O(3n)
        public int[] PivotArray(int[] nums, int pivot)
        {
            // try two passes - first build less than, then greater than.
            List<int> resultList = new List<int>();

            // Add Less Than list
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < pivot)
                    resultList.Add(nums[i]);
            }
            // Add pivots
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == pivot)
                    resultList.Add(nums[i]);
            }
            // Add Greater Than list
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > pivot)
                    resultList.Add(nums[i]);
            }

            return resultList.ToArray();
        }

        // =====================================
        // 162. Minimum Cost to Set Cooking Time
        // =====================================
        // User Accepted:1964
        // User Tried:3445
        // Total Accepted:2042
        // Total Submissions:9848
        // Difficulty:Medium

        // A generic microwave supports cooking times for:
        // at least 1 second.
        // at most 99 minutes and 99 seconds.
        // To set the cooking time, you push at most four digits.The microwave normalizes what you push as four digits by prepending zeroes.
        // It interprets the first two digits as the minutes and the last two digits as the seconds. It then adds them up as the cooking time.For example,

        // You push 9 5 4 (three digits). It is normalized as 0954 and interpreted as 9 minutes and 54 seconds.
        // You push 0 0 0 8 (four digits). It is interpreted as 0 minutes and 8 seconds.
        // You push 8 0 9 0. It is interpreted as 80 minutes and 90 seconds.
        // You push 8 1 3 0. It is interpreted as 81 minutes and 30 seconds.
        // You are given integers startAt, moveCost, pushCost, and targetSeconds.
        // Initially, your finger is on the digit startAt. Moving the finger above any specific digit costs moveCost units of fatigue.
        // Pushing the digit below the finger once costs pushCost units of fatigue.

        // There can be multiple ways to set the microwave to cook for targetSeconds seconds but you are interested in the way with the minimum cost.
        // Return the minimum cost to set targetSeconds seconds of cooking time.
        // Remember that one minute consists of 60 seconds.

        // Example 1:
        // Input: startAt = 1, moveCost = 2, pushCost = 1, targetSeconds = 600
        // Output: 6
        // Explanation: The following are the possible ways to set the cooking time.
        // - 1 0 0 0, interpreted as 10 minutes and 0 seconds.
        //   The finger is already on digit 1, pushes 1 (with cost 1), moves to 0 (with cost 2), pushes 0 (with cost 1), pushes 0 (with cost 1), and pushes 0 (with cost 1).
        //   The cost is: 1 + 2 + 1 + 1 + 1 = 6. This is the minimum cost.
        // - 0 9 6 0, interpreted as 9 minutes and 60 seconds.That is also 600 seconds.
        //  The finger moves to 0 (with cost 2), pushes 0 (with cost 1), moves to 9 (with cost 2), pushes 9 (with cost 1), moves to 6 (with cost 2), pushes 6 (with cost 1), moves to 0 (with cost 2), and pushes 0 (with cost 1).
        //   The cost is: 2 + 1 + 2 + 1 + 2 + 1 + 2 + 1 = 12.
        // - 9 6 0, normalized as 0960 and interpreted as 9 minutes and 60 seconds.
        //   The finger moves to 9 (with cost 2), pushes 9 (with cost 1), moves to 6 (with cost 2), pushes 6 (with cost 1), moves to 0 (with cost 2), and pushes 0 (with cost 1).
        //   The cost is: 2 + 1 + 2 + 1 + 2 + 1 = 9.

        // Example 2:
        // Input: startAt = 0, moveCost = 1, pushCost = 2, targetSeconds = 76
        // Output: 6
        // Explanation: The optimal way is to push two digits: 7 6, interpreted as 76 seconds.
        // The finger moves to 7 (with cost 1), pushes 7 (with cost 2), moves to 6 (with cost 1), and pushes 6 (with cost 2). The total cost is: 1 + 2 + 1 + 2 = 6
        // Note other possible ways are 0076, 076, 0116, and 116, but none of them produces the minimum cost.

        public int MinCostSetTime(int startAt, int moveCost, int pushCost, int targetSeconds)
        {
            return 0;
        }

        // ===========================================================
        // 2163. Minimum Difference in Sums After Removal of Elements
        // ===========================================================
        // User Accepted:427
        // User Tried:1098
        // Total Accepted:480
        // Total Submissions:1955
        // Difficulty:Hard

        // You are given a 0-indexed integer array nums consisting of 3 * n elements.
        // You are allowed to remove any subsequence of elements of size exactly n from nums.
        // The remaining 2 * n elements will be divided into two equal parts:
        // The first n elements belonging to the first part and their sum is sumfirst.
        // The next n elements belonging to the second part and their sum is sumsecond.
        // The difference in sums of the two parts is denoted as sumfirst - sumsecond.

        // For example, if sumfirst = 3 and sumsecond = 2, their difference is 1.
        // Similarly, if sumfirst = 2 and sumsecond = 3, their difference is -1.
        // Return the minimum difference possible between the sums of the two parts after the removal of n elements.

        // Example 1:
        // Input: nums = [3, 1, 2]
        // Output: -1
        // Explanation: Here, nums has 3 elements, so n = 1.
        // Thus we have to remove 1 element from nums and divide the array into two equal parts.
        // - If we remove nums[0] = 3, the array will be [1,2]. The difference in sums of the two parts will be 1 - 2 = -1.
        // - If we remove nums[1] = 1, the array will be [3,2]. The difference in sums of the two parts will be 3 - 2 = 1.
        // - If we remove nums[2] = 2, the array will be [3,1]. The difference in sums of the two parts will be 3 - 1 = 2.
        // The minimum difference between sums of the two parts is min(-1,1,2) = -1. 
        // Example 2:

        // Input: nums = [7,9,5,8,1,3]
        // Output: 1
        // Explanation: Here n = 2.So we must remove 2 elements and divide the remaining array into two parts containing two elements each.
        // If we remove nums[2] = 5 and nums[3] = 8, the resultant array will be[7, 9, 1, 3]. The difference in sums will be(7+9) - (1+3) = 12.
        // To obtain the minimum difference, we should remove nums[1] = 9 and nums[4] = 1.The resultant array becomes[7, 5, 8, 3].
        // The difference in sums of the two parts is (7+5) - (8+3) = 1.
        // It can be shown that it is not possible to obtain a difference smaller than 1.
        public long MinimumDifference(int[] nums)
        {
            return 0;
        }


    }

}
