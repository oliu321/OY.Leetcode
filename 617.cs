// 77.10% - NEED REVIEW!!!
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public TreeNode MergeTrees(TreeNode t1, TreeNode t2) {
        if (t1 == null) {
            if (t2 == null)
                return null;
            else
                return new TreeNode(t2.val) { left = t2.left, right = t2.right};
        }
        else if (t2 == null) {
            if (t1 == null)
                return null;
            else
                return new TreeNode(t1.val) { left = t1.left, right = t1.right};
        }
        else {
            return new TreeNode(t1.val + t2.val) { left = MergeTrees(t1.left, t2.left), right = MergeTrees(t1.right, t2.right)};
        }
    }
}