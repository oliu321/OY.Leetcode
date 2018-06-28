// 86.84%, need a way to speed up the processing
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
    public int MinDiffInBST(TreeNode root) { 
        int? min = null, max = null;
        return MindDiffInBSTInternal(root, ref min, ref max);        
    }
    
    protected int MindDiffInBSTInternal(TreeNode root, ref int? min, ref int? max)
    {
        int result = int.MaxValue;
        if (root == null)
            return result;
        min = null;
        max = null;
        int? lmin = null, lmax = null, rmin = null, rmax = null;
        if (root.left != null)
        {            
            int lresult = MindDiffInBSTInternal(root.left, ref lmin, ref lmax);
            if (lmin != null)
                min = lmin;
            result = lresult < result ? lresult : result;
        }
        if (root.right != null)
        {            
            int rresult = MindDiffInBSTInternal(root.right, ref rmin, ref rmax);
            if (rmax != null)
                max = rmax;
            result = rresult < result ? rresult : result;
        }
        
        if (min == null)
            min = root.val;
        else if (lmax.HasValue && result > (root.val - lmax.Value))
            result = root.val - lmax.Value;
        if (max == null)
            max = root.val;
        else if (rmin.HasValue && result > (rmin.Value - root.val))
            result = rmin.Value - root.val;
        
        return result;
    }
}