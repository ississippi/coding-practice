using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_practice_graph_leetcode
{

    // Definition for a Node.
    public class Node {
        public int val;
        public IList<Node> neighbors;

        public Node() {
            val = 0;
            neighbors = new List<Node>();
        }

        public Node(int _val) {
            val = _val;
            neighbors = new List<Node>();
        }

        public Node(int _val, List<Node> _neighbors) {
            val = _val;
            neighbors = _neighbors;
        }
    }


    public class CloneGraphLeetcode133
    {
        public Node CloneGraph(Node node)
        {
            var deepClone = new Node();
            return CloneGraphHelper(node, deepClone);
        }

        private Node CloneGraphHelper(Node node, Node deepClone)
        {
            if (node == null)
                return deepClone;
            foreach (var neighbor in node.neighbors)
            {
                deepClone.neighbors.Add(neighbor);
                CloneGraphHelper(neighbor, deepClone);

            }
            return deepClone;
        }
    }
}
