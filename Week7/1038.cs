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
    public int BstToGstInternal(TreeNode root, int parentVal) {
        int r = root.val;
        if (root.right != null)    {
            root.val += BstToGstInternal(root.right, parentVal);            
            r = root.val;
        }
        root.val += parentVal;
        
        
        if (root.left != null){
            r += BstToGstInternal(root.left, root.val);
        }
        
        return r;
    }
    public TreeNode BstToGst(TreeNode root) {        
        BstToGstInternal(root, 0);
        return root;
    }
}