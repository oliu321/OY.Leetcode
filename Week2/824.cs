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
                if(!isVowel){
                    b.Append(lastc);
                }
                b.Append("ma");
                ++w;
                for(int k = 0; k < w; ++k)
                    b.Append('a');                
                isFirstChar = true;
                b.Append(' ');
            }
            else {
                if(isFirstChar){
                    isFirstChar = false;
                    if(vowels.Contains(S[i])){
                        isVowel = true;
                        b.Append(S[i]);
                    }
                    else {
                        isVowel = false;
                        lastc = S[i];
                    }                        
                }
                else
                    b.Append(S[i]);
            }
        }
         if(!isVowel){
                    b.Append(lastc);
                }
                b.Append("ma");
                ++w;
                for(int k = 0; k < w; ++k)
                    b.Append('a'); 
        return b.ToString();
    }
}