public class Solution {
    public double MyPow(double x, int n) {
        if (n == 1)
            return x;
        if (n == -1)
            return 1/x;
        if (n == 0)
            return 1;
        
        int m = n / 2;
        double t = MyPow(x, m);
        return t*t * MyPow(x, n - 2*m);
    }
}