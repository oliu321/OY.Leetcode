//99.55%
public class Solution {
    public string ReverseWords(string s) {
        if(string.IsNullOrWhiteSpace(s))
            return s;
        
        int start = -1;
        int end = 0;
        StringBuilder result = new StringBuilder();
        for (; end < s.Length; ++end){
            if(s[end] != ' ')
                continue;
            
            for(int j = end - 1; j > start; --j)
                result.Append(s[j]);
            result.Append(' ');
            start = end;
        }
        
        if(start != end){
            for(int j = end - 1; j > start; --j)
                result.Append(s[j]);
        }
        
        return result.ToString();
    }
}