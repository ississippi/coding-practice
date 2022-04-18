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

        // 189. Rotate Array  https://leetcode.com/problems/rotate-array/
        public void Rotate(int[] nums, int k)
        {

        }
    }
}
