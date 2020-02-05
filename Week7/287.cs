public class Solution {
    public int FindDuplicate(int[] nums) {
        long l=1, h=nums.Length;
        while(l<h){
            long m = (l+h)/2;
            int cnt = 0;
            for(int i = 0; i < nums.Length; ++i){
                if (nums[i] <= m && nums[i] >= l)
                    ++cnt;
            }
            if (cnt > (m-l+1))
                h=m;
            else
                l=m+1;
        }
        return (int)l;
    }
}