﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_practice
{
    internal class LeetcodeBiweeklyContest78
    {
        // k-beauty - Accepted
        public int DivisorSubstrings(int num, int k)
        {
            var numStr = num.ToString();
            var ptr = 0;
            var beautyCounter = 0;
            while (ptr + k <= numStr.Length)
            {
                var valStr = numStr.Substring(ptr, k);
                var valNum = Int32.Parse(valStr);
                if (valNum == 0)
                {
                    ptr++;
                    continue;
                }
                if (num % valNum == 0)
                    beautyCounter++;
                ptr++;
            }
            return beautyCounter;
        }

        // This one exceeded time-limit - not accepted
        public int WaysToSplitArray(int[] nums)
        {
            var left = 0;
            var leftLen = 1;
            var leftValue = 0;
            var right = 1;
            var rightValue = 0;
            var waysCount = 0;
            var length = nums.Length;
            while (leftLen < length)
            {
                for (var i = 0; i < right; i++)
                {
                    leftValue += nums[i];
                }
                for (var i = right; i < length; i++)
                {
                    rightValue += nums[i];
                }
                if (leftValue >= rightValue)
                    waysCount++;
                //Console.WriteLine("leftlen: " + leftLen + " right: " + right + " leftValue: " + leftValue + " rightValue: " + rightValue);
                leftLen++;
                right = leftLen;
                leftValue = 0;
                rightValue = 0;
            }
            return waysCount;
        }

        // Accepted! (after the contest ended :) )
        // AND...
        // Runtime: 295 ms, faster than 100.00% of C# online submissions for Number of Ways to Split Array.
        // Memory Usage: 51.3 MB, less than 100.00% of C# online submissions for Number of Ways to Split Array.        
        public int WaysToSplitArray2(int[] nums)
        {
            var waysCount = 0;
            var leftValues = new double[nums.Length-1];
            var rightValues = new double[nums.Length-1];
            double accumulator = 0;
            for (var i = 0; i < nums.Length-1; i++)
            {
                accumulator += nums[i];
                leftValues[i] = accumulator;
            }
            accumulator = 0;
            for (var i = nums.Length - 1; i > 0; i--)
            {
                accumulator += nums[i];
                rightValues[i-1] = accumulator;
            }
            for (var i = 0; i < leftValues.Length; i++)
            {
                if (leftValues[i] >= rightValues[i])
                    waysCount++;
            }
            int intVar = 0;
            double dblVar = 0;
            for (var i = 1; i < 100000; i++)
            {
                intVar += i * -1;
                dblVar += i * -1;
            }
            Console.WriteLine("intVar: " + intVar + " dblVar: " + dblVar);
            return waysCount;
        }
    }
}
