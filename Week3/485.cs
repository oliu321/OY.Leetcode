// 91.88%
public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int max = 0, cur = 0;
        foreach(var num in nums){
            if (num == 0){
                max = Math.Max(max, cur);
                cur = 0;
            }
            else
                ++cur;
        }
        max = Math.Max(max, cur);
        return max;
    }
}