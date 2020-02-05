public class Solution {
    public int FindRadius(int[] houses, int[] heaters) {
        Array.Sort(houses);
        Array.Sort(heaters);        
        long l = 0, h = Math.Max(houses[houses.Length-1], heaters[heaters.Length-1]) - Math.Min(houses[0], heaters[0]);
        while(l<=h){
            long ii = (l+h)/2;
            int i = 0, j = 0;
            for(; (i < houses.Length) && (j < heaters.Length); ){
                if ((houses[i] >= (heaters[j] - ii)) && (houses[i] <= (heaters[j] + ii))){
                    ++i;
                }
                else{
                    ++j;
                }
            }
            if(i == houses.Length)
                h=ii-1;
            else
                l=ii+1;
        }             
        return (int)l;
    }
}