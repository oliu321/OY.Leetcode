public class Solution {
    public string ToGoatLatin(string S) {
        if (string.IsNullOrEmpty(S))
            return S;
        StringBuilder b = new StringBuilder();
        int w = 0;        
        HashSet<char> vowels = new HashSet<char>{'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'};
        bool isVowel = true;
        bool isFirstChar = true;
        char lastc = 'p';
        for(int i = 0; i < S.Length; ++i) {
            if(S[i] == ' ') {
                if(!isVowel) b.Append(lastc);                
                b.Append("ma");
                b.Append('a', ++w);
                isFirstChar = true;                
            }
            else if(isFirstChar){
                isFirstChar = false;
                isVowel = vowels.Contains(S[i]);
                if (!isVowel){
                    lastc = S[i];
                    continue;
                }                                    
            }
            b.Append(S[i]);
        }
        
        if(!isVowel) b.Append(lastc);               
        b.Append("ma");
        b.Append('a', ++w);
        return b.ToString();
    }
}