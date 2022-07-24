using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_practice
{
    internal class ZeroFilledSubarrays
    {
        public long ZeroFilledSubarray(int[] nums)
        {
            long ans = 0, cnt = 0;
            foreach (int x in nums.Append(1))
            {
                if (x == 0)
                    ++cnt;
                else
                {
                    ans += cnt * (cnt + 1) / 2;
                    cnt = 0;
                }
            }
            return ans;
        }

        // This is sum of n natural numbers - n(n+1)/2
        long zeroFilledSubarray(List<int> nums)
        {
            long result = 0;
            long count = 0;
            for (int i = 0; i < nums.Count(); i++)
            {
                if (nums[i] == 0)
                    count++;
                else
                {
                    result = result + (count * (count + 1)) / 2;
                    count = 0;
                }

            }
            return result + (count * (count + 1)) / 2;
        }
    }


}
