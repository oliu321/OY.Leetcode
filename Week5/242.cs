//
//99.12%
public class Solution {
    public bool IsAnagram(string s, string t) {
        int[] ss = new int[26];
        int[] tt = new int[26];
        foreach(var c in s)
            ++ss[c - 'a'];
        foreach(var c in t)
            ++tt[c - 'a'];
        for (int i = 0; i < 26; ++i)
        {
            if (ss[i] != tt[i])
                return false;
        }
        
        return true;
    }
}