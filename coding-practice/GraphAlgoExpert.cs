using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_practice_graph
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
    
    internal class DFSNode
    {
		public string name;
		public List<DFSNode> children = new List<DFSNode>();

		public DFSNode(string name)
		{
			this.name = name;
		}

		public List<string> DepthFirstSearch(List<string> array)
		{
			array.Add(this.name);
			foreach (var child in this.children)
			{
				child.DepthFirstSearch(array);
			}
			return array;
		}

		public DFSNode AddChild(string name)
		{
			DFSNode child = new DFSNode(name);
			children.Add(child);
			return this;
		}
	}

    internal class BFSNode
    {
		public string name;
		public List<BFSNode> children = new List<BFSNode>();

		public BFSNode(string name)
		{
			this.name = name;
		}

		public List<string> BreadthFirstSearch(List<string> array)
		{
			var nodeQueue = new Queue<BFSNode>();
			nodeQueue.Enqueue(this);

			while (nodeQueue.Count > 0)
			{
				var currentNode = nodeQueue.Dequeue();
				array.Add(currentNode.name);
				foreach (var child in currentNode.children)
					nodeQueue.Enqueue(child);
			}
			// Write your code here.
			return array;
		}

		public BFSNode AddChild(string name)
		{
			BFSNode child = new BFSNode(name);
			children.Add(child);
			return this;
		}
	}
}

