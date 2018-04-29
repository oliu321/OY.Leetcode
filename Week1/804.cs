// 97.47%
public class Solution {
    public int UniqueMorseRepresentations(string[] words) {
        string[] morse = new string[] {
            ".-","-...","-.-.","-..",".","..-.","--.","....","..",".---","-.-",".-..","--","-.","---",".--.","--.-",".-.","...","-","..-","...-",".--","-..-","-.--","--.."            
        };

        HashSet<string> rep = new HashSet<string>();
        foreach(var word in words)
        {
            var builder = new StringBuilder();
            foreach (var c in word)
                builder.Add(morse[c - 'a']);
            rep.Add(builder.ToString());
        }

        return rep.Count();        
    }
}