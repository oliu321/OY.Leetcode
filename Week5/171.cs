// 98.78%
public class Solution {
    public int TitleToNumber(string s) {
        int n = 0;
        if (s == null)
            return n;
        for (int i = 0; i < s.Length; ++i){
            n = n * 26 + (s[i] - 'A' + 1);
        }
        
        return n;
    }
}