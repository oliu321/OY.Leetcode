// 99.25%
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
    public bool FindTarget(TreeNode root, int k) {
        Stack<TreeNode> small = new Stack<TreeNode>();
        Stack<TreeNode> large = new Stack<TreeNode>();
        TreeNode s = root, l = root;
        while(s != null){
            small.Push(s);
            s = s.left;
        }
        while(l != null){
            large.Push(l);
            l = l.right;
        }
        
        while(small.Count > 0 && large.Count > 0)
        {
            s = small.Peek();
            l = large.Peek();
            if (s == l)
                return false;
            int val = s.val + l.val;
            if (val == k)
                return true;
            if (val < k)
            {
                small.Pop();
                if (s.right != null){
                    TreeNode t = s.right;
                    while(t != null){
                        small.Push(t);
                        t = t.left;
                    }
                }                                    
            }
            else if (val > k)
            {
                large.Pop();
                if (l.left != null){
                    TreeNode t = l.left;
                    while(t != null){
                        large.Push(t);
                        t = t.right;
                    }
                }
                
            }
        }
        
        return false;
    }   
}