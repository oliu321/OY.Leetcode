// 94.74%
public class Solution {
    public int CountBinarySubstrings(string s)
        {
            if (string.IsNullOrEmpty(s))
                return 0;

            int i = 0, j = 1;
            int c0 = 0, c1 = 0;
            bool zeroMode = (s[i] == '0');
            if (zeroMode) { c0 = 1; c1 = 0; } else { c1 = 1; c0 = 0; }
            int cnt = 0;
            while (i < s.Length && j < s.Length)
            {
                char firstPart = zeroMode ? '0' : '1';
                char secondPart = zeroMode ? '1' : '0';

                while (j < s.Length && s[j] == firstPart)
                {
                    if (zeroMode) ++c0; else ++c1;
                    ++j;
                }
                if (j == s.Length) break;
                while (j < s.Length && s[j] == secondPart && (c1 != c0))
                {
                    if (zeroMode) ++c1; else ++c0;
                    ++j;
                }
                i += (zeroMode ? c0 : c1);
                if (zeroMode) cnt += c1; else cnt += c0;
                if (i >= s.Length) break;
                zeroMode = (s[i] == '0');
                if (zeroMode) { c1 = 0; } else { c0 = 0; }
            }

            return cnt;
        }
    }
