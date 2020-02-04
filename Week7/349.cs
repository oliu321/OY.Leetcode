public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        HashSet<int> a = new HashSet<int>(nums1);
        HashSet<int> b = new HashSet<int>(nums2);
        return a.Intersect(b).ToArray();
    }
}