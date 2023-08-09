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
    public int MaxDepth(TreeNode root)
    {
        if (root == null)
        {
            return 0;
        }

        int leftDepth = MaxDepth(root.left);
        int rightDepth = MaxDepth(root.right);

        return Math.Max(leftDepth, rightDepth) + 1;
    }
}
