using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_practice_dfs
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
    internal class DFS
    {
        Node _root;

        public DFS Insert(int inValue)
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
        public List<int> DFSInOrder()
        {
            List<int> list = new List<int>();   
            return TraverseInOrder(this._root, list);
        }
        public List<int> DFSPostOrder()
        {
            List<int> list = new List<int>();
            return TraversePostOrder(this._root, list);
        }
        public List<int> DFSPreOrder()
        {
            List<int> list = new List<int>();
            return TraversePreOrder(this._root, list);
        }

        private List<int> TraverseInOrder(Node node, List<int> resultList)
        {
            if (node.left != null)
            {
                TraverseInOrder(node.left, resultList);
            }
            resultList.Add(node.val);
            if (node.right != null)
            {
                TraverseInOrder(node.right, resultList);
            } 
            return resultList;
        }

        private List<int> TraversePreOrder(Node node, List<int> resultList)
        {
            resultList.Add(node.val);
            if (node.left != null)
            {
                TraversePreOrder(node.left, resultList);
            }
            if (node.right != null)
            {
                TraversePreOrder(node.right, resultList);
            }
            return resultList;
        }
        private List<int> TraversePostOrder(Node node, List<int> resultList)
        {
            if (node.left != null)
            {
                TraversePostOrder(node.left, resultList);
            }
            if (node.right != null)
            {
                TraversePostOrder(node.right, resultList);
            }
            resultList.Add(node.val);
            return resultList;
        }
    }

}
