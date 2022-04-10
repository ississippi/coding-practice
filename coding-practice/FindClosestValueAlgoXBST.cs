using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_practice
{
	internal class FindClosestValueAlgoXBST
	{
		public static int FindClosestValueInBst(BST tree, int target)
		{
			var closest = Int32.MaxValue - 1;
			return FindClosestHelper(tree, target, closest);
		}

		public static int FindClosestHelper(BST tree, int target, int closest)
		{
			if (tree == null)
				return closest;
			if (Math.Abs(target - closest) > Math.Abs(target - tree.value))
				closest = tree.value;
			if (target < tree.value)
				return FindClosestHelper(tree.left, target, closest);
			else if (target > tree.value)
				return FindClosestHelper(tree.right, target, closest);
			else
				return closest;
		}

		public static int FindClosestValueInBstIterative(BST tree, int target)
		{
			var closest = Int32.MaxValue - 1;
			return FindClosestIterativeHelper(tree, target, closest);
		}
		// Average time O(log(n)) Space O(1)
		// Worst O(n) Space O(n)
		public static int FindClosestIterativeHelper(BST tree, int target, int closest)
		{
			var currentNode = tree;
			if (currentNode == null)
				return closest;
			while (currentNode != null)
			{
				if (Math.Abs(target - closest) > Math.Abs(target - currentNode.value))
					closest = currentNode.value;
				if (target < currentNode.value)
					currentNode = currentNode.left;
				else if (target > currentNode.value)
					currentNode = currentNode.right;
				else
					break;
			}
			return closest;
		}


	}
	public class BST
	{
		public int value;
		public BST left;
		public BST right;

		public BST(int value)
		{
			this.value = value;
		}
	}
}
