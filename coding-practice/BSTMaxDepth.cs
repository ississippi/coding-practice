using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_practice_maxDepth
{

// Definition for a binary tree node.
  public class TreeNode {
      public int val;
      public TreeNode left;
      public TreeNode right;
      public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
          this.val = val;
          this.left = left;
          this.right = right;
      }
  }
    public class BinarySearchTree
    {
        TreeNode _root = null;
        BinarySearchTree()
        {
            this._root = new TreeNode();
        }
    }
    //public int MaxDepth(TreeNode root)
    //{

    //}

    internal class BSTMaxDepth
    {
        //      function traverse(node)
        //      {
        //          const tree = { value: node.value };
        //          tree.left = node.left === null ? null : traverse(node.left);
        //          tree.right = node.right === null ? null : traverse(node.right);
        //return tree;
    }

}
