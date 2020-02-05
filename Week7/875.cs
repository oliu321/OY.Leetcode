public class Solution {
    public int MinEatingSpeed(int[] piles, int H) {
        long s = 0;
        for (int i = 0; i < piles.Length; ++i)
            s +=  piles[i];
        long l = s/H + 1;
        long h = l * 2;
        while(l<=h){
            long t = 0;
            long m  = (l+h)/2;
            for(int i = 0; i < piles.Length; ++i){
                t += piles[i]/((int)m) + (piles[i]%((int)m) == 0 ? 0 : 1);
            }
            if(t <= H)
                h=m-1;
            else
                l=m+1;
        }
        
        return (int)l;
    }
}