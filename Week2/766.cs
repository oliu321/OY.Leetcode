// 99%
public class Solution {
    public bool IsToeplitzMatrix(int[,] matrix) {
        int h = matrix.GetLength(0);
        int w = matrix.GetLength(1);
        int n = Math.Max(h, w);
        int i = n-1, j;
        for (int d = -1*(n-1); d < n; ++d){
            i = (d < 0) ? -1 * d : 0;
            j = i + d;
            int v = -1;
            for (int di = i, dj = j; true; ++di, ++dj){
                if (di >= h)
                    break;
                if (dj >= w)
                    break;
                if (v == -1){
                    v = matrix[di,dj];
                }
                else if (v != matrix[di,dj])
                    return false;
            }
        }        
        
        return true;
    }
}