using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_practice
{
    internal class MajorityElementClass
    {
        public int MajorityElement(int[] nums)
        {
            if (nums.Length == 0)
                return 0;
            if (nums.Length == 1)
                return nums[0];
            var me = 0;
            Dictionary<int, int> d = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (d.ContainsKey(nums[i]))
                {
                    d[nums[i]]++;
                }
                else
                {
                    d.Add(nums[i], 1);    
                }
            }
            var max = 0;
            foreach(var item in d)
            {
                if(item.Value > max)
                {
                    me = item.Key;  
                    max = item.Value;   
                }
            }
            return me;
        }

        //Given an array nums of size n, return the majority element.
        //The majority element is the element that appears more than ⌊n / 2⌋ times.You may assume that the majority element always exists in the array.
        // My answer above missed the > n/2 specification
        public int MajorityElementLeetCodeAnswer(int[] nums)
        {
            int majorityCount = nums.Length / 2;

            foreach (int num in nums)
            {
                int count = 0;
                foreach (int elem in nums)
                {
                    if (elem == num)
                    {
                        count += 1;
                    }
                }
                if (count > majorityCount)
                {
                    return num;
                }
            }

            return -1;
        }
    }
}
