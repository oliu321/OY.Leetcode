public class Solution {
    public int ShipWithinDays(int[] weights, int D) {
        int l = weights.Sum() / D + (weights.Sum()%D == 0 ? 0 : 1), h = weights.Max() * (weights.Length / D  + 1);
        while (l<=h){
            int m = l + (h-l)/2;
            int c = 0, t = 0;
            bool failed = false;
            for (int i = 0; i < weights.Length; ++i){
                if (weights[i] > m){
                    failed = true; break;
                }
                if (t + weights[i] >= m){
                    ++c;
                    t = (t + weights[i] > m) ? weights[i] : 0;
                }
                else
                    t += weights[i];
            }
            if (t != 0)
                ++c;
            if (failed || c > D)
                l = m + 1;
            else
                h = m - 1;
        }
        
        return l;
    }
}