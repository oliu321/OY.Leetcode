// 95.83%
public class Solution {
    public bool DetectCapitalUse(string word) {
        if(word.Length <= 1)
            return true;
        bool isFirstCapital = char.IsUpper(word[0]);
        bool isCapital = char.IsUpper(word[1]);
        if(!isFirstCapital && isCapital)
            return false;
        for(int i = 2; i < word.Length; ++i) {
            if(char.IsUpper(word[i]) != isCapital)
                return false;
        }
        return true;
    }
}