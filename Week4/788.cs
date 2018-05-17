// 100%
public class Solution {
    public int RotatedDigits(int N) {
        int cnt = 0;
        for(int i = 1; i <= N; ++i){
            int k = i;
            bool Find2569 = false;            
            while(k > 0){
                int j = k % 10;
                if (j == 3 || j == 4 || j == 7)
                    break;
                else if (j == 2 || j == 5 || j == 6 || j == 9)
                    Find2569 = true;
                k = k / 10;
            }
            if (k == 0 && Find2569)
                ++cnt;
        }
        return cnt;
    }
}