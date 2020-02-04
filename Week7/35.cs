public class Solution {
    public int SearchInsert(int[] nums, int target) {
        int l = 0, h = nums.Length - 1;
        int pos = -1;
        while (l <= h){
            int i = (l+h)/2;
            if (nums[i] > target)
                h = i-1;         
            else if (nums[i] < target)
                l = i+1;                            
            else
                return i;
        }
        return l;
    }
}