//100.0%
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
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
    public int GetMinimumDifference(TreeNode root) {
        return GetMinimumDifferenceInternal(root, out int max, out int min);
        
    }
    public int GetMinimumDifferenceInternal(TreeNode root, out int max, out int min){
        if (root == null){
            max = -1; min = -1;
            return Int32.MaxValue;
        }
        int lmd = GetMinimumDifferenceInternal(root.left, out int lmax, out int lmin);
        int rmd = GetMinimumDifferenceInternal(root.right, out int rmax, out int rmin);
        min = lmin == -1 ? root.val : lmin; max = rmax == -1 ? root.val : rmax;
        int md = Int32.MaxValue;
        if (lmax != -1){
            md = root.val - lmax;
        }
        if (rmin != -1){
            md = Math.Min(md, rmin - root.val);
        }
        
        md = Math.Min(md, lmd);
        md = Math.Min(md, rmd);
        
        return md;
    }
}