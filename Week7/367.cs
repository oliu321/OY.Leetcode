public class Solution {
    public bool IsPerfectSquare(int num) {
        long h = num, l = 1;
        while(h >= l){
            long i = (h+l)/2;
            long ii = i * i;
            if (ii > num)
                h = i-1;
            else if (ii < num)
                l = i+1;
            else
                return true;
        }
        return false;
    }
}