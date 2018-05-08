// 100% - but can be improved I think
public class Solution {
    public bool HasAlternatingBits(int n) {            
        bool isOne = (n % 2 == 0);
        while(n != 0){
            n >>= 1;
            if (isOne){
                if (n % 2 == 0) return false;
            } 
            else {
                if (n % 2 == 1) return false;
            }
            isOne = !isOne;            
        }
        return true;
    }
}