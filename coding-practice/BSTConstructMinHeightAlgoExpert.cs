using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_practice
{
	internal class BSTConstructMinHeightAlgoExpert
	{
		public static BSTAlgo MinHeightBst(List<int> array)
		{
			return constructMinHeightBST(array, null, 0, array.Count - 1);
		}
		private static BSTAlgo constructMinHeightBST(List<int> array, BSTAlgo bst, int startIdx, int endIdx)
		{
			if (endIdx < startIdx)
				return null;
			var midIdx = Math.Abs((startIdx + endIdx) / 2);
			var valueToAdd = array[midIdx];
			if (bst == null)
				bst = new BSTAlgo(valueToAdd);
			else
				bst.insert(valueToAdd);

			constructMinHeightBST(array, bst, startIdx, midIdx - 1);
			constructMinHeightBST(array, bst, midIdx + 1, endIdx);
			return bst;
		}
	}
	public class BSTAlgo
	{
		public int value;
		public BSTAlgo left;
		public BSTAlgo right;

		public BSTAlgo(int value)
		{
			this.value = value;
			left = null;
			right = null;
		}

		public void insert(int value)
		{
			if (value < this.value)
			{
				if (left == null)
				{
					left = new BSTAlgo(value);
				}
				else
				{
					left.insert(value);
				}
			}
			else
			{
				if (right == null)
				{
					right = new BSTAlgo(value);
				}
				else
				{
					right.insert(value);
				}
			}
		}
		}
	}

}
