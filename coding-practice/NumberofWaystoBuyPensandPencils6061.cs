using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_practice
{
    internal class NumberofWaystoBuyPensandPencils6061
    {
        public long WaysToBuyPensPencils(int total, int cost1, int cost2)
        {
            var ways = 0;
            var remainingMoney = total;
            var maxIterations1 = Math.Abs(total / cost1);
            var maxIterations2 = Math.Abs(total / cost2);
            if (maxIterations1 > 0)
            {
                for (var i = 0; i <= maxIterations1; i++)
                {
                    remainingMoney = total - (cost1 * i);
                    ways += 1;
                    if (remainingMoney < cost1)
                    {

                        continue;
                    }
                    for (var j = 0; j <= maxIterations2; j++)
                    {
                        remainingMoney = remainingMoney - (cost2 * j);
                        ways += 1;
                        if (remainingMoney < cost2)
                        {
                            break;
                        }
                    }
                }
            }

            return ways;
        }
    }
}
