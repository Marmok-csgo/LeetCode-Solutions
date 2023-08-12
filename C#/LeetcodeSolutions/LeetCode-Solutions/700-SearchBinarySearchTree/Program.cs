using System;

public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null) {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public class Solution {
    public TreeNode SearchBST(TreeNode root, int val) {
        return Search(root, val);
    }
    
    private TreeNode Search(TreeNode node, int val) {
        if (node == null) {
            return null;
        }

        if (val > node.val) {
            return Search(node.right, val);
        }
        else if (val < node.val) {
            return Search(node.left, val);
        }
        else {
            return node;
        }
    }
}