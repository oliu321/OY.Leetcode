// 99.04%
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
    public TreeNode ConvertBST(TreeNode root) {
        ConvertBSTInternal(root, 0);
        return root;
    }
    public int ConvertBSTInternal(TreeNode root, int upper) {
        if (root == null)
            return 0;
        int right = ConvertBSTInternal(root.right, upper);
        int sum = right + root.val;
        root.val += upper;
        root.val += right;
        sum += ConvertBSTInternal(root.left, root.val);
        return sum;
    }
}