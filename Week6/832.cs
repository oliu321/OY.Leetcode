// Not enough data for perf
public class Solution {
    public int[][] FlipAndInvertImage(int[][] A) {
        foreach(var row in A) {
            for(int i = 0, j = row.Length - 1; i <= j; ++i, --j){
                int t = 1- row[j];
                row[j] = 1 - row[i];
                row[i] = t;
            }
        }
        return A;
    }
}