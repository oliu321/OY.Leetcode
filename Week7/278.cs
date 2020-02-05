/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

public class Solution : VersionControl {
    public int FirstBadVersion(int n) {
        long l = 1, h = n;
        long i = -1;
        while(l<=h){
            i = (l+h)/2;
            bool r = IsBadVersion((int)i);
            if (r)
                h=i-1;
            else
                l=i+1;
        }
        return (int)l;
    }
}