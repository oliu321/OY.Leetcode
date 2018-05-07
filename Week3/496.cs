// 93% - Should be able to improve
public class Solution {
    public int[] NextGreaterElement(int[] findNums, int[] nums) {
        Dictionary<int, int> ngn = new Dictionary<int, int>();
        int lastChecked = -1;
        for (int i = 0; i < nums.Length; ++i){
            ngn[nums[i]] = -1;
            for (int j = i + 1; j < nums.Length; ++j){
                if (nums[j] > nums[i]){
                    ngn[nums[i]] = nums[j];
                    break;
                }
            }
        }
        for(int k = 0; k < findNums.Length; ++k)
            findNums[k] = ngn[findNums[k]];
        return findNums;
    }
}