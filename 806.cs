// 32.70% need review
public class Solution {
    public int[] NumberOfLines(int[] widths, string S) {
        int t = 0;
        int lines = 1;
        int lastLine = 0;
        foreach(var c in S) {
            int w = widths[c - 'a'];
            if (t + w > 100) {
                t = w;
                ++lines;
                lastLine = t;
            }
            else {
                t += w;
                lastLine = t;
            }
        }
        return new int[] {lines, lastLine};
    }
}