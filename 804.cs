// 89.87% to be improved
public class Solution {
    public int UniqueMorseRepresentations(string[] words) {
        string[] morse = new string[] {
            ".-","-...","-.-.","-..",".","..-.","--.","....","..",".---","-.-",".-..","--","-.","---",".--.","--.-",".-.","...","-","..-","...-",".--","-..-","-.--","--.."            
        };
        
        return words.Select(s => string.Join("", s.Select(c => morse[c - 'a']).ToArray())).Distinct().Count();
    }
}