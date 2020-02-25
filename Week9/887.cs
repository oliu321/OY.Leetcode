public class Solution {
    public int SuperEggDrop(int K, int N) {
        int[] table = new int[K + 1];
        int step = 0;
        for (; table[K] < N; ++step)
            for(int i = K; i > 0; --i){
                table[i] += table[i-1] + 1;
            }
        return step;
    }
}