// 99.69%
public class Solution {
    public bool RotateString(string A, string B) {
        if (A == null && B == null)
            return true;
        if (A == null || B == null)
            return false;
        if (A.Length != B.Length)
            return false;
        if (A.Length == 0)
            return true;
        
        for(int i = 1; i < A.Length; ++i){
            bool match = true;
            for (int j = 0; j < A.Length; ++j){
                if(A[(i+j) % A.Length] != B[j]){
                    match = false;
                    break;
                }
            }
            if (match)
                return true;
        }
        
        return false;
    }
}