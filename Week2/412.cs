// 94.54%
public class Solution {
    public IList<string> FizzBuzz(int n) {        
        IList<string> result = new List<string>();
        for(int i = 1; i <= n; ++i) {
            bool f = (i%3 == 0), b = (i%5==0);
            if(f){
                if(b)
                    result.Add("FizzBuzz");
                else
                    result.Add("Fizz");
            }
            else{
                if(b)
                    result.Add("Buzz");
                else
                    result.Add(i.ToString());
            }
        }
        
        return result;
    }
}