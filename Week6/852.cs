// Not enough data for per
public class Solution {
    public int PeakIndexInMountainArray(int[] A) {
        int i = 1;
        while(A[i] > A[i-1])
            ++i;
        return i - 1;
    }
}