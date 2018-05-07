// 93.08% could be improved? - at least remove recursion
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
    public IList<double> AverageOfLevels(TreeNode root) {
        Dictionary<int, double> levelSum = new Dictionary<int, double>();
        Dictionary<int, int> levelCnt = new Dictionary<int, int>();
        AverageOfLevelsInternal(root, 0, levelSum, levelCnt);
        double[] average = new double[levelCnt.Count()];
        for (int i = 0; i < average.Length; ++i)
            average[i] = levelSum[i] / levelCnt[i];
        return average;
    }
    private void AverageOfLevelsInternal(TreeNode root, int level, Dictionary<int, double> levelSum, Dictionary<int, int> levelCnt){
        if (root == null)
            return;
        
        if(levelSum.ContainsKey(level)) {
            levelSum[level] += root.val;
            levelCnt[level] += 1;
        }
        else{
            levelSum[level] = root.val;
            levelCnt[level] = 1;
        }
        
        AverageOfLevelsInternal(root.left, level + 1, levelSum, levelCnt);
        AverageOfLevelsInternal(root.right, level + 1, levelSum, levelCnt);
    }
}