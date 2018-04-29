// 84.91% perf unreliable
public class Solution
{
    public int[] NumberOfLines(int[] widths, string S)
    {
        int t = 0;
        int lines = 1;
        int lastLine = 0;
        foreach (var c in S)
        {
            int w = widths[c - 'a'];
            lastLine += w;
            if (lastLine > 100)
            {
                lastLine = w;
                ++lines;
            }
        }
        return new int[] { lines, lastLine };
    }
}