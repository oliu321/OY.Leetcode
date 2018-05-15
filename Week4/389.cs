// 45.10%
public class Solution {
    public char FindTheDifference(string s, string t) {
        var ss = s.OrderBy(c => c).ToArray();
        var tt = t.OrderBy(c => c).ToArray();
        int i = 0;
        for(; i < ss.Length; ++i){
            if (ss[i] != tt[i])
                return tt[i];
        }
        return tt[i];
    }
}