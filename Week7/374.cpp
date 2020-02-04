// Forward declaration of guess API.
// @param num, your guess
// @return -1 if my number is lower, 1 if my number is higher, otherwise return 0
int guess(int num);

class Solution {
public:
    int guessNumber(int n) {
        long l = 1, h = n;
        while(l<=h){
            long i = (l+h)/2;
            int r = guess(i);
            if (r > 0)
                l = i+1;
            else if (r<0)
                h = i-1;
            else
                return (int)i;
        }
        return 0;
    }
};