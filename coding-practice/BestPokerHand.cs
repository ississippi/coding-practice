using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_practice
{
    internal class BestPokerHand
    {
        public string BestHand(int[] ranks, char[] suits)
        {
            var handDic = new Dictionary<string, int>();

            for (int i = 0; i < suits.Length; i++)
            {
                if (handDic.ContainsKey(suits[i].ToString()))
                    handDic[suits[i].ToString()] += 1;
                else
                    handDic.Add(suits[i].ToString(), 1);
            }
            if (handDic[suits[0].ToString()] == suits.Length)
                return "Flush";
            var rankDic = new Dictionary<int, int>();

            for (int i = 0; i < ranks.Length; i++)
            {
                if (rankDic.ContainsKey(ranks[i]))
                    rankDic[ranks[i]] += 1;
                else
                    rankDic.Add(ranks[i], 1);
            }
            foreach (var item in rankDic)
            {
                var foundPair = false;
                if (item.Value >= 3)
                    return "Three of a Kind";
                if (item.Value == 2)
                    foundPair = true;
                if (foundPair == true)
                    return "Pair";
            }
            
            return "High Card";
        }
    }
}
