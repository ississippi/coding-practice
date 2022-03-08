using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_practice
{
    internal class BinaryTreeSearch700
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
        public TreeNode SearchBST(TreeNode root, int val)
        {
            if (root == null || val == root.val)
                return root;
            return (val > root.val) ? SearchBST(root.right, val) : SearchBST(root.left, val);
        }
    }
}
