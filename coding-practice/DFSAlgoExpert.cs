using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_practice
{

	// https://www.algoexpert.io/questions/Depth-first%20Search
	public class NodeDFSAloExpert
	{
		public string name;
		public List<NodeDFSAloExpert> children = new List<NodeDFSAloExpert>();

		public NodeDFSAloExpert(string name)
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

		public NodeDFSAloExpert AddChild(string name)
		{
			NodeDFSAloExpert child = new NodeDFSAloExpert(name);
			children.Add(child);
			return this;
		}
	}

}
