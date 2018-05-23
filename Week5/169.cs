// 38.15%
public class Solution {
    public int MajorityElement(int[] nums) {
        var s = new Stack<int>();
        foreach(var n in nums){
            if(s.Count == 0)
                s.Push(n);
            else{
                int m = s.Peek();
                if (m == n)
                    s.Push(n);
                else
                    s.Pop();
            }
        }
        
        return s.Peek();
    }
}