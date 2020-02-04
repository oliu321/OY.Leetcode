public class Solution {
    public int ArrangeCoins(int n) {
        long l = 1, h = n;
        while(l<=h){
            long i = (l+h)/2;
            long ii = (i*i + i)/2;
            if (ii > n)
                h=i-1;
            else if (ii < n)
                l=i+1;
            else
                return (int)i;
        }
        return (int)h;
    }
}