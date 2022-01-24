using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_practice
{
    internal class MoveZeroesSolution
    {
        public int[] MoveZeroes(int[] nums)
        {
            for (int lastNonZeroFoundAt = 0, cur = 0; cur < nums.Length; cur++)
            {
                if (nums[cur] != 0)
                {
                    Swap(lastNonZeroFoundAt++, cur, nums);
                }
            }
            return nums;
        }

        private void Swap(int val1, int val2, int[] arr)
        {
            var temp = arr[val1];
            arr[val1] = arr[val2];  
            arr[val2] = temp;   
        }
    }
}
