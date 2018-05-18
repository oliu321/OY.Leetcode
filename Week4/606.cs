// 100%
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
    public string Tree2str(TreeNode t) {
        if (t == null)
            return string.Empty;
        StringBuilder b = new StringBuilder();     
        Visit(t, b);
        var s = b.ToString();
        return s.Substring(1, s.Length - 2);
    }
    public void Visit(TreeNode t, StringBuilder b){
        if (t == null)
            return;
        b.Append($"({t.val}");
        if (t.left == null){
            if(t.right != null)            
            {
                b.Append($"()");
                Visit(t.right, b);                
            }
        }
        else {            
            Visit(t.left, b);
            if (t.right != null){
                Visit(t.right, b);
            }            
        }
        b.Append(')');
    }
}