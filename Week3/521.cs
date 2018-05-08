// Useless problem
public class Solution {
    public int FindLUSlength(string a, string b) {
        if (a == null)
            return -1;
        if (b == null)
            return -1;
        
        int la = a.Length, lb = b.Length;
        if (la == lb)
            return a == b ? -1: la;
        else
            return Math.Max(la, lb);
    }
}