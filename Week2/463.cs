// 86.83%
public class Solution {    
    public int IslandPerimeter(int[,] grid) {
        HashSet<int> neighbours = new HashSet<int>();
        int h = grid.GetLength(0), w = grid.GetLength(1);
        int p = 0;
        for (int i = 0; i < h; ++i) {
            for (int j = 0; j < w; ++j){
                if (grid[i,j] == 0)
                    continue;
                
                int l = -1, r = -1, u = -1, d = -1;
                int c = i * w + j;
                if (j > 0)
                    l = c - 1;
                if (j < w - 1)
                    r = c + 1;
                if (i > 0)
                    u = c - w;
                if (i < h - 1)
                    d = c + w;
                
                if (!neighbours.Contains(l)) ++p; else --p;
                if (!neighbours.Contains(r)) ++p; else --p;
                if (!neighbours.Contains(u)) ++p; else --p;
                if (!neighbours.Contains(d)) ++p; else --p;
                neighbours.Add(c);
            }
        }
        
        return p;
    }
}