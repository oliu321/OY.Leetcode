// 99.13%
public class Solution {
    public bool IsToeplitzMatrix(int[,] matrix) {
        int h = matrix.GetLength(0);
        int w = matrix.GetLength(1);
        
        for (int i = 1; i < h; ++i) {
            for (int j = 1; j < w; ++j) {
                if (matrix[i,j] != matrix[i-1,j-1]) return false;
            }
        }
        
        return true;
    }
}
