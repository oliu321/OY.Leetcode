public class Solution {
    public char NextGreatestLetter(char[] letters, char target) {
        int l = 0, h = letters.Length - 1;
        while(l <= h){
            int i = (l+h)/2;
            if (letters[i] <= target)
                l = i + 1;
            else if (letters[i] > target)
                h = i - 1;            
        }
        
        return l == letters.Length ? letters[0] : letters[l];
    }
}