public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> t = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; ++i)
            t[nums[i]] = i;
        
        for (int i = 0; i < nums.Length; ++i){
            int tt = target - nums[i];
            if (t.ContainsKey(tt)){
                if (i != t[tt])
                    return new int[]{i, t[tt]};
            }
        }
        return new int[]{-1,-1};
    }
}