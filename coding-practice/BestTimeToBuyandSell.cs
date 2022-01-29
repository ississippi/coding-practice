using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_practice
{
    internal class BestTimeToBuyandSell
    {
        public int MaxProfit(int[] prices)
        {
            var total = 0;
            var peak = Int32.MaxValue;
            var valley = peak;

            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] < peak)
                {
                    total += peak - valley;
                    valley = prices[i];
                    peak = valley;
                }
                else
                {
                    peak = prices[i];
                }
            }
            total += peak - valley;
            return total;
        }

        public int MaxProfitClean(int[] prices)
        {
            var total = 0;

            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] > prices[i - 1])
                {
                    total += prices[i] - prices[i - 1];
                }
            }
            return total;
        }
    }
}
