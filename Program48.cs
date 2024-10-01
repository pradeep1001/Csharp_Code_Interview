﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Pradeep_1
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
    public class Program48 : TreeNode
    {
        public bool EvaluateTree(TreeNode root)
        {
            if (root.left == null && root.right == null)
            {
                if (root.val == 0)
                    return false;
                return true;
            }
            bool left = EvaluateTree(root.left);
            bool right = EvaluateTree(root.right);
            if (root.val == 2)
                return left || right;
            return left && right;
        }
        public static void Main(string[] args)
        {

        }
    }
}
