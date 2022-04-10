using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_practice
{
    internal class QuickSortAlgoExpert
    {
		public static int[] QuickSort(int[] array)
		{
			QuickSortHelper(array, 0, array.Length - 1);
			return array;
		}

		public static int[] QuickSortHelper(int[] array, int startIdx, int endIdx)
		{
			if (startIdx >= endIdx)
				return array;
			var pivotIdx = startIdx;
			var leftIdx = startIdx + 1;
			var rightIdx = endIdx;
			while (rightIdx >= leftIdx)
			{
				if (array[leftIdx] > array[pivotIdx] && array[rightIdx] < array[pivotIdx])
					Swap(leftIdx, rightIdx, array);
				if (array[leftIdx] <= array[pivotIdx])
					leftIdx += 1;
				if (array[rightIdx] >= array[pivotIdx])
					rightIdx -= 1;
			}
			Swap(pivotIdx, rightIdx, array);
			var leftSubarrayIsSmaller = (rightIdx - 1 - startIdx) < (endIdx - (rightIdx + 1));
			if (leftSubarrayIsSmaller)
			{
				QuickSortHelper(array, startIdx, rightIdx - 1);
				QuickSortHelper(array, rightIdx + 1, endIdx);
			}
			else
			{
				QuickSortHelper(array, rightIdx + 1, endIdx);
				QuickSortHelper(array, startIdx, rightIdx - 1);
			}

			return array;
		}
		public static void Swap(int i, int j, int[] array)
		{
			var temp = array[j];
			array[j] = array[i];
			array[i] = temp;
		}
	}
}
