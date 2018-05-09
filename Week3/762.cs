// 96.77%
public class Solution {
    public int CountPrimeSetBits(int L, int R) {
        HashSet<byte> primes = new HashSet<byte>{2,3,5,7,11,13,17,19,23,29,31};
        int cnt = 0;
        byte bits = 0;
        int k = L;
        while(k != 0){
            if (k % 2 == 1)
                ++bits;
            k >>= 1;
        }
        if (primes.Contains(bits))
            ++cnt;
        
        for (int i = L+1; i <= R; ++i){
            k = i;
            while((k -1) % 2 == 1){
                --bits;
                k >>= 1;
            }
            ++bits;            
            if (primes.Contains(bits))
                ++cnt;           
        }
        return cnt;
    }
}