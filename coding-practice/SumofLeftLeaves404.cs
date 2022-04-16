using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_practice
{
    //internal class SumofLeftLeaves404
    //{
    //    int sumOfLeftLeaves(TreeNode* root)
    //    {

    //        return sumOfLeftLeaves(root, false);
    //    }

    //    int sumOfLeftLeaves(TreeNode* root, bool leftNode)
    //    {
    //        if (root == null)
    //            return 0;

    //        if (root.left == null && root.right == null)
    //        {
    //            if (leftNode)
    //                return root.val;
    //            else
    //                return 0;
    //        }

    //        var sum = 0;
    //        if (root.left != null)
    //        {
    //            sum += sumOfLeftLeaves(root.left, true); // <-- is where 10 execution
    //        }
    //        if (root.right != null)
    //        {
    //            sum += sumOfLeftLeaves(root.right, false);
    //        }

    //        return sum;
    //    }
    //}

    // Definition for a binary tree node.
    public class TreeNode404 {
        public int val;
        public TreeNode404 left;
        public TreeNode404 right;
        public TreeNode404(int val=0, TreeNode404 left =null, TreeNode404 right =null) {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
 
}
