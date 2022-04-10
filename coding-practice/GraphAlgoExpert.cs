using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_practice
{
    internal class SingleCycle
    {
		// Time O(n) Space O(1)
		public static bool HasSingleCycle(int[] array)
		{
			var numElementsVisited = 0;
			var idx = 0;
			while (numElementsVisited < array.Length)
			{
				if (numElementsVisited > 0 && idx == 0) return false;
				numElementsVisited++;
				idx = getNextIdx(idx, array);
			}
			return idx == 0;
		}

		public static int getNextIdx(int currentIdx, int[] array)
		{
			int jump = array[currentIdx];
			var nextIdx = (currentIdx + jump) % array.Length;
			return nextIdx >= 0 ? nextIdx : nextIdx + array.Length;
		}
	}
}
