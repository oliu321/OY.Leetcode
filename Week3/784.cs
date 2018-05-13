// 86.44%
public class Solution {
    public IList<string> LetterCasePermutation(string S) {
        int letterCnt = S.Count(c => char.IsLetter(c));
        if(letterCnt == 0)
            return new string[]{S};
        IList<string> result = new List<string>();
        for(int i = 0; i < (1 << letterCnt); ++i){
            StringBuilder b = new StringBuilder();
            int d = 0;
            for(int j = 0; j < S.Length; ++j){
                if(char.IsLetter(S[j])){
                    if((i & (1 << d)) == 0)
                        b.Append(char.ToLower(S[j]));
                    else
                        b.Append(char.ToUpper(S[j]));
                    ++d;
                }
                else
                    b.Append(S[j]);
            }
            result.Add(b.ToString());
        }
        return result;
    }
}