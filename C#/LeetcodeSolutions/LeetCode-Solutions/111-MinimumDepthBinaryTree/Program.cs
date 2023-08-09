using System;

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

public class Solution
{
    public int MinDepth(TreeNode root)
    {
        if (root == null)
        {
            return 0;
        }

        if (root.left == null && root.right == null)
        {
            return 1;
        }

        int leftDepth = int.MaxValue;
        int rightDepth = int.MaxValue;

        if (root.left != null)
        {
            leftDepth = MinDepth(root.left);
        }

        if (root.right != null)
        {
            rightDepth = MinDepth(root.right);
        }

        return Math.Min(leftDepth, rightDepth) + 1;
    }
}
