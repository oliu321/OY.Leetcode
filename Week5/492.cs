//54.84%
public class Solution {
    public int[] ConstructRectangle(int area) {
        if (area == 1)
                return new int[] { 1, 1 };
            int w = (int)Math.Sqrt(area);            
            int rw = 0, rl = 0, min_dis = area;
            for (int i = 1; i <= w; ++i)
            {
                if (area % i != 0)
                    continue;
                rl = area / i;
                if (rl - i < min_dis)
                {
                    rw = i;
                    min_dis = rl - i;
                }
            }
            return new int[] { rl, rw };
    }
}