// 97.78%
public class Solution {    
    public bool JudgeCircle(string moves) {
        int uStepsCnt = 0, lStepsCnt = 0;
        for(int i = 0; i < moves.Length; ++i) {
            switch(moves[i]){
                case 'u':
                case 'U':
                    ++uStepsCnt;
                    break;
                case 'd':
                case 'D':
                    --uStepsCnt;
                    break;
                case 'l':
                case 'L':
                    ++lStepsCnt;
                    break;
                case 'r':
                case 'R':
                    --lStepsCnt;
                    break;
                default:
                    break;
            }
        }
        return uStepsCnt == 0 && lStepsCnt == 0;
    }
}