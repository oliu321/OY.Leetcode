// 94.19% (is it possible to remove the tail recursion?)
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution
{
    public TreeNode MergeTrees(TreeNode t1, TreeNode t2)
    {
        if (t1 == null)
        {
            if (t2 == null)
                return null;
            else
                return t2;
        }
        else if (t2 == null)
        {
            if (t1 == null)
                return null;
            else
                return t1;
        }
        else
        {
            return new TreeNode(t1.val + t2.val) { left = MergeTrees(t1.left, t2.left), right = MergeTrees(t1.right, t2.right) };
        }
    }
}