using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_practice
{
    internal class AmazonDetermineWinner
    {
        public class Players
        {
            public bool player1 { get; set; }
            public bool player2 { get; set; }
        }

        //public Players determineWinner(int[] h1, int[] h2)
        //{
        //    Players players = new Players();
        //    players = TwoPairCheck(h1, h2);
        //    if (players.player1 != false || players.player2 != false)
        //        return players;

        //    players = OnePairCheck(h1, h2);
        //    if (players.player1 != false || players.player2 != false)
        //        return players;

        //    players = HighCardCheck(h1, h2);

        //    return players;
        //}

        private Players OnePairCheck(int[] h1, int[] h2)
        {
            Players players = new Players();
            var dicDigits1 = new Dictionary<int,int>();
            var dicDigits2 = new Dictionary<int,int>();

            for (var i = 0; i < h1.Length; i++)
            {
                if (dicDigits1.ContainsKey(h1[i]))
                    dicDigits1[h1[i]] += 1;
            }
            for (var i = 0; i < h2.Length; i++)
            {
                if (dicDigits2.ContainsKey(h2[i]))
                    dicDigits2[h2[i]] += 1;
            }
            var sum1 = 0;
            foreach (var item in dicDigits1)
            {
                sum1 += item.Value / 2; // [2,2,2,2,3] 2:4, 3:1
            }
            var sum2 = 0;
            foreach (var item in dicDigits2)
            {
                //sum2 += Math.Floor((double)(item.Value / 2));// [13,13,12,9,8] 13:2, 12:1, 9:1, 8:1
            }
            if (sum1 > sum2)
            {
                players.player1 = true;
                return players;
            }
            if (sum1 < sum2)
            {
                players.player2 = true;
                return players;
            }

            return players;




        }

        //private Players HighCardCheck(int[] h1, int[] h2)
        //{

        //}
    }
}
