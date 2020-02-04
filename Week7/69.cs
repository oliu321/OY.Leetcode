public class Solution {
    public int MySqrt(int x) {
        long l = 0, h = x;
        while(l<=h){
            long i = (l+h)/2;
            long ii = i*i;
            if (ii < x)
                l=i+1;
            else if (ii > x)
                h=i-1;
            else
                return (int)i;
        }
        return (int)h;
    }
}