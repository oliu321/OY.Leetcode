// 99.31%
public class Solution {
    public int AddDigits(int num) {
        while(num >= 10){
            int t = 0;
            do{
                t += num % 10;
                num /= 10;
            }while(num != 0);
            num = t;
        }
        return num;
    }
}