using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_practice
{
    internal class FindClosestNumbertoZero6060
    {
    public int FindClosestNumber(int[] nums)
        {
            int min = Int32.MaxValue - 1;
            int minNum = Int32.MaxValue - 1;
            foreach (var num in nums)
            {
                if (num == 0)
                {
                    return num;
                }
                var diff = 0 - num;
                if (Math.Abs(min) > Math.Abs(diff))
                {
                    min = Math.Abs(diff);
                    minNum = num;
                }
                if(Math.Abs(num) == Math.Abs(minNum))
                {
                    minNum = (minNum >= num) ? minNum : num;
                }
            }
            return minNum;
        }

    }
}
