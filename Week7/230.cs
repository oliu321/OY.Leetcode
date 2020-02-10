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
    public int KthSmallestInternal(TreeNode root, int k, ref int? elem)
    {
        if (root == null)
            return 0;
        
        int ls = KthSmallestInternal(root.left, k, ref elem);
        if (elem != null)
            return -1;
        
        if (ls == k-1){
            elem = root.val;
            return -1;
        }
        
        int rs = KthSmallestInternal(root.right, k - ls - 1, ref elem);
        if (elem != null)
            return -1;
        return ls + rs + 1;
    }
    public int KthSmallest(TreeNode root, int k) {
        int? elem = null;
        KthSmallestInternal(root, k, ref elem);
        return elem.Value;
    }
}