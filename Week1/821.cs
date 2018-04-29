// probably can be improved
public class Solution {
    public int[] ShortestToChar(string S, char C) {
        List<int> locations = new List<int>();
        for (int i = 0; i < S.Length; ++i) {
            if (S[i] == C)
                locations.Add(i);
        }
        var locationsArr = locations.ToArray();
        int[] distances = new int[S.Length];
        int lastC = -1 * (S.Length + 1);
        int remote = 2 * (S.Length + 1);
        int idx = 0;
        for (int i = 0; i < S.Length; ++i){
            distances[i] = Math.Min(i - lastC, (idx == locationsArr.Length) ? remote : locationsArr[idx] - i);
            if (distances[i] == 0){
                lastC = locationsArr[idx++];
            }
        }
        return distances;
    }
}