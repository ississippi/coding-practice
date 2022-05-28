using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_practice
{
    internal class BinarySearchLeetcodeAlgo1
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

        // 278. First Bad Version - Binary search approach
        // You are a product manager and currently leading a team to develop a new product.
        // Unfortunately, the latest version of your product fails the quality check.
        // Since each version is developed based on the previous version,
        // all the versions after a bad version are also bad.
        // Suppose you have n versions[1, 2, ..., n] and you want to find out the first bad one,
        // which causes all the following ones to be bad.
        // You are given an API bool isBadVersion(version) which returns whether version is bad.
        // Implement a function to find the first bad version.
        // You should minimize the number of calls to the API.
        
        // My Accepted solution
        // O(n) time and O(1) space
        public int FirstBadVersion(int n)
        {
            while (IsBadVersion(n))
            {
                n--;
            }
            return n + 1;
        }
        // Binary search approach
        // O(logn) time and O(1) space
        public int FirstBadVersionSolution2(int n)
        {
            var left = 0;
            var right = n;
            while (left < right)
            {
                var mid = left + (right - left) / 2;
                if (IsBadVersion(mid))
                {
                    right = mid;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return left;
        }
        public bool IsBadVersion(int n)
        {
            // not coded:
            return true;
        }

        // 35. Search Insert Position
        // Given a sorted array of distinct integers and a target value,
        // return the index if the target is found.
        // If not, return the index where it would be if it were inserted in order.
        // You must write an algorithm with O(log n) runtime complexity.
        public int SearchInsert(int[] nums, int target)
        {
            var pivot = (nums.Length - 1) / 2;
            var left = 0;
            var right = nums.Length - 1;

            while (left <= right)
            {
                pivot = left + (right - left) / 2;
                //pivot = (right + left) >>> 1; faster but more complex
                if (nums[pivot] == target)
                    return pivot;
                if (target < nums[pivot])
                    right = pivot - 1;
                else
                    left = pivot + 1;
            }
            return left;
        }
        // 704. Binary Search
        // https://leetcode.com/problems/binary-search/
        public int BinarySearch(int[] nums, int target)
        {
            int pivot = 0;
            var left = 0;
            var right = nums.Length - 1;
            while (left <= right)
            {
                pivot = left + (right - left) / 2;
                if (nums[pivot] == target)
                    return pivot;
                if (target < nums[pivot]) right = pivot - 1;
                else left = pivot + 1;
            }
            return -1;
        }
    }
}

