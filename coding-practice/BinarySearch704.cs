using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_practice
{
    internal class BinarySearch704
    {
        // Given an array of integers nums which is sorted in ascending order, and an integer target,
        // write a function to search target in nums.
        // If target exists, then return its index. Otherwise, return -1.
        // You must write an algorithm with O(log n) runtime complexity.
        // Example 1:
        // Input: nums = [-1, 0, 3, 5, 9, 12], target = 9
        // Output: 4
        // Explanation: 9 exists in nums and its index is 4
        // Example 2:
        // Input: nums = [-1, 0, 3, 5, 9, 12], target = 2
        // Output: -1
        // Explanation: 2 does not exist in nums so return -1

        // Algorithm
        // Initialise left and right pointers : left = 0, right = n - 1.
        // While left <= right :
        // Compare middle element of the array nums[pivot] to the target value target.
        // If the middle element is the target target = nums[pivot] : return pivot.
        // If the target is not yet found :
        // If target < nums[pivot], continue the search on the left right = pivot - 1.
        // Else continue the search on the right left = pivot + 1.
        
        public int Search(int[] nums, int target)
        {
            var pivot = (nums.Length - 1) / 2;
            var left = 0;
            var right = nums.Length - 1;

            while (left <= right)
            {
                pivot = left + (right - left) / 2;
                if (nums[pivot] == target) return pivot;
                if (target < nums[pivot]) right = pivot - 1;
                else left = pivot + 1;
            }
            return -1;
        }
    }
}
