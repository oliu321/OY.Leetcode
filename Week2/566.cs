// 93.98%
public class Solution {
    public int[,] MatrixReshape(int[,] nums, int r, int c) {
        int or = nums.GetLength(0);
        int oc = nums.GetLength(1);
        if (or*oc != r*c || or == r)
            return nums;
        
        int[,] nnums = new int[r,c];
        for (int i = 0; i < or*oc; ++i){
            nnums[i/c, i%c] = nums[i/oc, i%oc];
        }
        return nnums;
    }
}