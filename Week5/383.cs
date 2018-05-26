// 100%
public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        int[] rn = new int[26];
        int[] m = new int[26];
        foreach(var c in ransomNote){
            ++rn[c - 'a'];
        }
        foreach(var c in magazine){
            ++m[c - 'a'];
        }
        for (int i = 0; i < 26; ++i){
            if (rn[i] > m[i])
                return false;
        }
        return true;
    }
}