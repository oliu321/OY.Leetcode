// 96.62% Tried multiple times, the correctness of the algorithm can be proved inductively
public class Solution {
    public int ArrayPairSum(int[] nums) {
        Array.Sort(nums);
        int sum = 0;
        for (int i = 0; i < nums.Length; i += 2 )
            sum += nums[i];
        return sum;
    }
}