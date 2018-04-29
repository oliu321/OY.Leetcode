// 95.80% may be able to improve it
public class Solution {
    public IList<int> SelfDividingNumbers(int left, int right) {
        List<int> result = new List<int>();
        for (int i = left; i <= right; ++i){
            if (IsSelfDividingNumber(i))
                result.Add(i);
        }              
        return result;
    }
    
    private bool IsSelfDividingNumber(int i) {                
        int j = i;
        if (i >= 1000) {
            int a = j / 1000; j -= a * 1000;
            if (i % a != 0) return false;
        }
        if (i >= 100) {
            int b = j / 100; j -= b * 100;
            if (b == 0 || i % b != 0) return false;
        }
        if (i >= 10) {
            int c = j / 10; j -= c * 10;
            if (c == 0 || i % c != 0) return false;
        }       
        return j > 0 && i % j == 0;
    }
}