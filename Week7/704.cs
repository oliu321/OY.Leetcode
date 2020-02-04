public class Solution {
    public int Search(int[] nums, int target) {
        int low = 0, high = nums.Length - 1;
        while(low <= high){
            int i = (low + high) / 2;
            if (nums[i] > target)
                high = i - 1;
            else if (nums[i] < target)
                low = i + 1;
            else
                return i;
        }
        return -1;
    }
}