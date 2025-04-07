using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_practice
{
    internal class TwoPointersLeetcodeAlgo1
    {
        // 977. Squares of a Sorted Array - https://leetcode.com/problems/squares-of-a-sorted-array/
        public int[] SortedSquares(int[] nums)
        {
            int[] result = new int[nums.Length];
            var len = nums.Length - 1;
            var left = 0;
            var right = len;

            for (var i = len; i >= 0; i--)
            {
                var square = 0;
                if (Math.Abs(nums[left]) > Math.Abs(nums[right]))
                {
                    square = nums[left];
                    left++;
                }
                else
                {
                    square = nums[right];
                    right--;
                }
                result[i] = square * square;
            }
            return result;

        }

        public int[] SortedSquares2(int[] nums)
        {
            var result = new List<int>();

            foreach (var num in nums)
            {
                result.Add(num * num);
            }
            result.Sort();

            return result.ToArray();
        }

        // 189. Rotate Array  https://leetcode.com/problems/rotate-array/
        // Time complexity: O(n×k). All the numbers are shifted by one step
        // Space complexity: O(1)
        public void Rotate(int[] nums, int k)
        {
            // speed up the rotation
            k %= nums.Length;
            int temp, previous;
            for (int i = 0; i < k; i++)
            {
                previous = nums[nums.Length - 1];
                for (int j = 0; j < nums.Length; j++)
                {
                    temp = nums[j];
                    nums[j] = previous;
                    previous = temp;
                }
            }
        }
        // Time complexity: O(n).
        // One pass is used to put the numbers in the new array. And another pass to copy the new array to the original one.
        // Space complexity: O(n) Another array of the same size is used
        public void RotateExtraArray(int[] nums, int k)
        {
            int[] a = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                a[(i + k) % nums.Length] = nums[i];
            }
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = a[i];
            }
        }

        public void MoveZeroes(int[] nums)
        {
            var j = 0;
            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    nums[j++] = nums[i];
                }
            }
            for (var i = j; i < nums.Length; i++)
            {
                nums[i] = 0;
            }
        }

        // Time: O(n^2) Space: O(1)
        public int[] TwoSum(int[] numbers, int target)
        {
            int[] result = new int[2];
            for (var i = 0; i < numbers.Length; i++)
            {
                for (var j = i+1; j < numbers.Length; j++)
                {
                    //if (numbers[j] > target && numbers[j] != 0)
                    //    break;
                    if (numbers[i] + numbers[j] == target)
                    {
                        result[0] = i + 1;
                        result[1] = j + 1;
                    }
                }
            }
            return result;
        }

        // Time: O(n) Space: O(n)
        public int[] TwoSumDictionary(int[] nums, int target)
        {
            var seenMap = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                var cur = nums[i];
                var x = target - cur;
                if (seenMap.ContainsKey(x))
                {
                    return new int[2] {
                    seenMap[x],
                    i
                };
                }
                if (!seenMap.ContainsKey(cur))
                    seenMap.Add(cur, i);
            }
            return new int[2];
        }

    }
}
