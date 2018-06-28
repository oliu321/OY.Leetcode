// 96.88%, may only need 1 pass?
public class Solution {
    public int MinMoves(int[] nums) {
        if (nums == null || nums.Length == 0)
            return 0;
        int min = nums[0];
        for (int i = 1; i < nums.Length; ++i)
        {
            if (min > nums[i])
                min = nums[i];
        }
        
        int result = 0;
        for (int i = 0; i < nums.Length; ++i)
        {
            result += nums[i] - min;
        }
        
        return result;
    }
}