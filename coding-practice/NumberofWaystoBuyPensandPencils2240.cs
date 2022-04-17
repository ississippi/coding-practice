using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_practice
{
    internal class NumberofWaystoBuyPensandPencils2240
    {
        // Works
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
                    if (remainingMoney < cost1)
                    {
                        ways += 1;
                        continue;
                    }
                    for (var j = 0; j <= maxIterations2; j++)
                    {
                        if (j > 0)
                            remainingMoney = remainingMoney - cost2;
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


        // Leetcode Discussion Solution I like
        public long waysToBuyPensPencils(int total, int cost1, int cost2)
        {
            long ans = 0;
            for (int i = 0; i * cost1 <= total; i++)
                ans += (cost2 + total - i * cost1) / cost2;
            return ans;
        }

        // Another Leetcode Discussion Solution I like
        // This is a question of observing
        // First example clearly gives idea to solve this.
        // Input: total = 20, cost1 = 10, cost2 = 5
        // Output: 9

        // Explanation: The price of a pen is 10 and the price of a pencil is 5.
        // If you buy 0 pens, you can buy 0, 1, 2, 3, or 4 pencils.
        // If you buy 1 pen, you can buy 0, 1, or 2 pencils.
        // If you buy 2 pens, you cannot buy any pencils.
        // The total number of ways to buy pens and pencils is 5 + 3 + 1 = 9.

        // Idea
        // As we can see we have to try number of ways:
        // just calulate how much pen i can buy with this total
        // for example in 1st expmple you can buy from range 0 to 2 pens.
        // So available choice are 0 pens, for that just think how much pencil you can buy
        // i.e m = remaining amount / pencil cost
        // you can buy maximum m pencils so you have m + 1 choices
        // Now try for next choosen way of pen buying i.e buy 1 pen.
        public long waysToBuyPensPencils2(int total, int cost1, int cost2)
        {
            long ways = 0;
            long penscost = 0;
            while (penscost <= total)
            {
                long remainingAmount = total - penscost;
                long pencils = remainingAmount / cost2 + 1;
                ways += pencils;
                penscost += cost1;
            }
            return ways;
        }
    }
}
