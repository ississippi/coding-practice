using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_practice
{
    internal class RecursionProductSumAlgoEx
    {
        public int ProductSum(List<object> array, int multiplier = 1)
        {
            var sum = 0;
            foreach (var item in array)
            {
                if (item is int)
                {
                    sum += (int)item * multiplier;
                }
                else if (item is List<object>)
                {
                    sum += ProductSum((List<object>)item, multiplier + 1);
                }
            }

            return sum * multiplier;
        }
    }
}
