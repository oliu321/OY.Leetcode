// 99.31%
public class Solution {
    public int NumJewelsInStones(string J, string S) {
        bool[] jewels = new bool[256];
        for (int i = 0; i < J.Length; ++i)
        {
            jewels[(int)J[i]] = true;
        }
        
        int cnt = 0;
        for (int i = 0; i < S.Length; ++i)
        {
            if (jewels[(int)S[i]])
                ++cnt;
        }
        return cnt;
    }
}