//93.96%
public class Solution {
    public static readonly byte[] locations = new byte[26] {
        2,3,3,2,1,2,2,2,1,2,2,2,3,3,1,1,1,1,2,1,1,3,1,3,1,3
    };
    
    public string[] FindWords(string[] words) {
        if (words == null)
            return null;
        
        List<string> result = new List<string>();        
        foreach(var word in words){
            if(word == null)
                continue;
            
            bool isOneRowWord = true;
            byte pos = locations[char.ToLower(word[0]) - 'a'];            
            for(int i = 1; i < word.Length; ++i) {                
                if (locations[char.ToLower(word[i]) - 'a'] != pos){
                    isOneRowWord = false;
                    break;
                }
            }                    
            
            if(isOneRowWord)
                result.Add(word);
        }
        
        return result.ToArray();
    }
}