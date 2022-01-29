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

    }
}
