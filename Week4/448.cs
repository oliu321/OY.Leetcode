// 97.50%
public class Solution {
    public IList<int> FindDisappearedNumbers(int[] nums) {
        if (nums == null)
            return null;
        
        for(int i = 0; i < nums.Length; ++i){
            int shouldBe = i + 1;
            int actually = nums[i];
            if((actually != shouldBe) && (nums[actually - 1] != actually))
            {
                nums[i] = nums[actually - 1];
                nums[actually - 1] = actually;
                --i;
            }
        }
        
        List<int> result = new List<int>();
        for (int i = 0; i < nums.Length; ++i){
            if (nums[i] != i + 1)
                result.Add(i + 1);
        }
        
        return result;
    }
}