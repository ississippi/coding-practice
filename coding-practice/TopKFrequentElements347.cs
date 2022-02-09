using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_practice
{
    internal class TopKFrequentElements347
    {
        public int[] TopKFrequent(int[] nums, int k)
        {
            var topK = new int[k];    
            var dic = new Dictionary<int, int>();   
            foreach (int c in nums)
            {
                if (dic.ContainsKey(c))
                {
                    dic[c]++;
                }
                else
                {
                    dic.Add(c, 1);
                }
            }

            return topK;
        }
    }
}
