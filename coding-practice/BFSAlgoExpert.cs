using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_practice
{
	public class NodeBFS
	{
		public string name;
		public List<NodeBFS> children = new List<NodeBFS>();

		public NodeBFS(string name)
		{
			this.name = name;
		}

		public List<string> BreadthFirstSearch(List<string> namesArray)
		{
			var nodeQueue = new Queue<NodeBFS>();
			nodeQueue.Enqueue(this);

			while (nodeQueue.Count > 0)
			{
				var currentNode = nodeQueue.Dequeue();
				namesArray.Add(currentNode.name);
				foreach (var child in currentNode.children)
					nodeQueue.Enqueue(child);
			}
			// Write your code here.
			return namesArray;
		}

		public NodeBFS AddChild(string name)
		{
			NodeBFS child = new NodeBFS(name);
			children.Add(child);
			return this;
		}
	}
}
