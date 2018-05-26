// 94.44%
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
    public int SumOfLeftLeaves(TreeNode root) {
        return SumOfLeftLeavesInternal(root, false);
    }
    public int SumOfLeftLeavesInternal(TreeNode root, bool leftDirection) {
        if (root == null)
            return 0;
        if (root.left == null && root.right == null)
            return leftDirection ? root.val : 0;
        return SumOfLeftLeavesInternal(root.left, true) + SumOfLeftLeavesInternal(root.right, false);
    }
}