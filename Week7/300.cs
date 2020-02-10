public class Solution {
    public int LengthOfLIS(int[] nums) {
 	int[] lis = new int[nums.Length];
	int max = 0;
	for (int i = nums.Length-1; i >=0; --i){
		int t = 0;
		for (int j = i+1; j < nums.Length; ++j){
			if ((nums[j] > nums[i]) && lis[j] > t)
				t = lis[j];
		}
		lis[i] = t+1;
		if (lis[i] > max)
			max = lis[i];
	}
        
        return max;
    }
}