using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_practice_maxDepth
{

    // Definition for a binary tree node.
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x)
        {
            this.val = x;
        }
    }
    public class Solution
    {
        public int MaxDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            else
            {
                int left_height = MaxDepth(root.left);
                int right_height = MaxDepth(root.right);
                return (left_height < right_height) ? right_height + 1 : left_height + 1;
            }
        }
    }

}
