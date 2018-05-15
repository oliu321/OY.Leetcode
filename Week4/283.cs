// 26.40%, need O(n)
public class Solution {
    public void MoveZeroes(int[] nums) {
        if(nums == null) return;
        
        int zeroStarts = nums.Length;
        for(int i = nums.Length - 1; i >= 0; --i){
            if (nums[i] != 0) continue;
            for (int k = i; k < zeroStarts - 1; ++k){
                nums[k] = nums[k+1];
            }
            nums[--zeroStarts] = 0;
        }
    }
}