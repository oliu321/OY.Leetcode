// Not enough data for percentage
public class Solution {
    public IList<IList<int>> LargeGroupPositions(string S) {
        if (S == null)
            return null;
        
        IList<IList<int>> result = new List<IList<int>>();
        int start = 0, end = 0;
        
        for(end = 1; end < S.Length; ++end){
            if(S[end] == S[end - 1])
                continue;
            if (end - start >= 3){
                result.Add(new int[]{start, end - 1});
            }
            start = end;
        }
        
        if (end - start >= 3){
            result.Add(new int[]{start, end - 1});
        }
        
        return result;
    }
}