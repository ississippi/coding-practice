using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_practice
{
    internal class FindDuplicates442
    {
        // Given an integer array nums of length n where all the integers of nums are in the range[1, n]
        // and each integer appears once or twice, return an array of all the integers that appears twice.
        // You must write an algorithm that runs in O(n) time and uses only constant extra space.

        // Example 1:
        // Input: nums = [4,3,2,7,8,2,3,1]
        // Output: [2,3]

        // Example 2:
        // Input: nums = [1,1,2]
        // Output: [1]

        // Example 3:
        // Input: nums = [1]
        // Output: []
        public IList<int> FindDuplicates(int[] nums)
        {
            List<int> ans = new List<int>();

            for (var i = 0; i < nums.Length; i++)
            {
                var num = nums[i];
                var absNum = Math.Abs(num);
                if (nums[absNum - 1] < 0)
                {  // seen before
                    ans.Add(absNum);
                }
                nums[absNum - 1] *= -1;
            }

            return ans;
        }
    }
}
