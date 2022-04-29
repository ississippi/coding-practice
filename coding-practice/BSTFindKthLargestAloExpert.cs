using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_practice
{
    internal class BSTFindKthLargestAloExpert
    {
		// This is an input class. Do not edit.
		public class BST
		{
			public int value;
			public BST left = null;
			public BST right = null;

			public BST(int value)
			{
				this.value = value;
			}
		}

		// Solution 1: Brute force.
		// Visit all nodes inorder to build a sorted array then return the Kth value from the end
		public int FindKthLargestValueInBst(BST tree, int k)
		{
			List<int> nodeValues = new List<int>();
			TraverseInOrder(tree, nodeValues);
			return nodeValues[nodeValues.Count - k];
		}

		private void TraverseInOrder(BST t, List<int> nodeValues)
		{
			if (t == null)
				return;
			TraverseInOrder(t.left, nodeValues);
			nodeValues.Add(t.value);
			TraverseInOrder(t.right, nodeValues);
		}


		public class TreeInfo
		{
			public int visitCount { get; set; }
			public int lastValue { get; set; }
			public TreeInfo(int vCount, int lVal)
			{
				visitCount = vCount;
				lastValue = lVal;
			}
		}
        
		public int FindKthLargestValueInBst2(BST tree, int k)
		{
			var treeInfo = new TreeInfo(0, -1);
			TraverseReverseInorder(tree, k, treeInfo);
			return treeInfo.lastValue;
		}
		private void TraverseReverseInorder(BST node, int k, TreeInfo treeInfo)
		{
			if (node == null || treeInfo.visitCount >= k)
				return;
			TraverseReverseInorder(node.right, k, treeInfo);
			if (treeInfo.visitCount < k)
			{
				treeInfo.visitCount++;
				treeInfo.lastValue = node.value;
				TraverseReverseInorder(node.left, k, treeInfo);
			}
		}
	}
}
