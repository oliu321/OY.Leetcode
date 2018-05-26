// 98.81%
public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        HashSet<int> hs = new HashSet<int>(nums);
        return hs.Count() != nums.Length;
    }
}