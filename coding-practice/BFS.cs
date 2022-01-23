using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_practice_bfs
{
    public class Node
    {
        public int val;
        public Node left;
        public Node right;
        public Node(int val = 0)
        {
            this.val = val;
        }
    }
    public class BFS
    {
        public Node _root;
        public BFS()
        {
        }
        public BFS Insert(int inValue)
        {
            var newNode = new Node(inValue);
            if (this._root == null)
            {
                this._root = newNode;
            }
            else
            {
                var currentNode = this._root;
                while (true)
                {
                    if (inValue < currentNode.val)
                    {
                        //Left
                        if (currentNode.left == null)
                        {
                            currentNode.left = newNode;
                            return this;
                        }
                        currentNode = currentNode.left;
                    }
                    else
                    {
                        //Right
                        if (currentNode.right == null)
                        {
                            currentNode.right = newNode;
                            return this;
                        }
                        currentNode = currentNode.right;
                    }
                }
            }
            return this;
        }
        public List<int> BreadthFirstSearch(int value)
        {
            var currentNode = _root;
            var nodeList = new List<int>();
            var nodeQueue = new Queue<Node>();
            nodeQueue.Enqueue(currentNode);

            while (nodeQueue.Count > 0)
            {
                currentNode = nodeQueue.Dequeue();
                nodeList.Add(currentNode.val);
                if (currentNode.left != null) { nodeQueue.Enqueue(currentNode.left); }
                if (currentNode.right != null) { nodeQueue.Enqueue(currentNode.right); }
            }
            return nodeList;
        }

        public List<int> BreadthFirstSearchR(Queue<Node> nodeQueue, List<int> nodeList)
        {
            if (nodeQueue.Count == 0)
            {
                return nodeList;
            }
            var currentNode = nodeQueue.Dequeue();
            nodeList.Add(currentNode.val);
            if (currentNode.left != null) { nodeQueue.Enqueue(currentNode.left); }
            if (currentNode.right != null) { nodeQueue.Enqueue(currentNode.right); }
            return BreadthFirstSearchR(nodeQueue, nodeList);
        }
    }
}
