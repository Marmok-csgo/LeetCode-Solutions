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
    private List<int> retList = new List<int>();
    private List<int> retList1 = new List<int>();

    public bool LeafSimilar(TreeNode root1, TreeNode root2)
    {
        Traversal(root1);
        Traversal2(root2);
        return retList.SequenceEqual(retList1);
    }

    private bool IsLeaf(TreeNode root)
    {
        return root.left == null && root.right == null;
    }

    private void Traversal(TreeNode root)
    {
        if (root != null)
        {
            Traversal(root.left);
            if (IsLeaf(root))
            {
                retList.Add(root.val);
            }
            Traversal(root.right);
        }
    }

    private void Traversal2(TreeNode root)
    {
        if (root != null)
        {
            Traversal2(root.left);
            if (IsLeaf(root))
            {
                retList1.Add(root.val);
            }
            Traversal2(root.right);
        }
    }
}