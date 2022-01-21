using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_practice
{
    internal class SingleNumber
    {
        public int DoSingleNumber(int[] nums)
        {
            var dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!dict.ContainsKey(nums[i]))
                {
                    dict.TryAdd(nums[i], 0);
                }
                else
                {
                    dict[nums[i]] += 1;
                }
            }
            foreach (KeyValuePair<int, int> item in dict)
            {
                if (item.Value == 0)
                    return item.Key;
            }
            return -1;
        }

        public int SingleNumberLeetCodeList(int[] nums)
        {
            var no_duplicate_list = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (!no_duplicate_list.Contains(nums[i]))
                {
                    no_duplicate_list.Add(nums[i]);
                }
                else
                {
                    no_duplicate_list.Remove(nums[i]);
                }
            }
            return no_duplicate_list[0];
        }

        public int SingleNumberLeetCodeMath(int[] nums)
        {
            int sumOfSet = 0, sumOfNums = 0;
            var set = new HashSet<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (!set.Contains(nums[i]))
                {
                    set.Add(nums[i]);
                    sumOfSet += nums[i];
                }
                sumOfNums += nums[i];
            }
            return 2 * sumOfSet - sumOfNums;
        }
    }
}
