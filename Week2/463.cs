// 100%
public class Solution {    
    public int IslandPerimeter(int[,] grid) {        
        int h = grid.GetLength(0), w = grid.GetLength(1);
        int p = 0;
        for (int i = 0; i < h; ++i) {
            for (int j = 0; j < w; ++j){
                if (grid[i,j] == 0)
                    continue;
                
                int l = -1, r = -1, u = -1, d = -1;
                int c = i * w + j;
                if (j == 0 || grid[i, j - 1] == 0)
                    ++p;
                if (j == w - 1 || grid[i, j + 1] == 0)
                    ++p;
                if (i == 0 || grid[i - 1, j] == 0)
                    ++p;
                if (i == h - 1 || grid[i + 1, j] == 0)
                    ++p;               
            }
        }
        
        return p;
    }
}