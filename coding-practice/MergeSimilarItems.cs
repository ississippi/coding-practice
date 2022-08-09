using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_practice
{
    internal class MergeSimilarItems
    {
        public IList<IList<int>> MergeSimilarItemsContest(int[][] items1, int[][] items2)
        {
            var dicWeights = new SortedList<int, int>();
            foreach (var itemArr in items1)
            {
                var valItem = itemArr[0];
                if (dicWeights.ContainsKey(valItem))
                    dicWeights[itemArr[0]] += itemArr[1];
                else
                    dicWeights.Add(valItem, itemArr[1]);
            }
            foreach (var itemArr in items2)
            {
                var valItem = itemArr[0];
                if (dicWeights.ContainsKey(valItem))
                    dicWeights[itemArr[0]] += itemArr[1];
                else
                    dicWeights.Add(valItem, itemArr[1]);
            }
            var result = new List<IList<int>>();
            foreach(var valArr in dicWeights)
            {
                int[] arr;
                arr = new int[2];
                arr[0] = valArr.Key;
                arr[1] = valArr.Value;
                result.Add(arr);
            }

            return result;
        }
    }
}
