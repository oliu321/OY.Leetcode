//93.96%
public class Solution {
    public string[] FindWords(string[] words) {
        if (words == null)
            return null;
        
        List<string> result = new List<string>();
        HashSet<char>[] rows = new HashSet<char>[] {
            new HashSet<char>("qwertyuiop".ToCharArray()),
            new HashSet<char>("asdfghjkl".ToCharArray()),
            new HashSet<char>("zxcvbnm".ToCharArray()),
        };
        
        foreach(var word in words){
            if(word == null)
                continue;
            int row = rows[0].Contains(char.ToLower(word[0])) ? 0 : (rows[1].Contains(char.ToLower(word[0])) ? 1 : 2);
            bool isOneRowWord = true;
            for(int i = 1; i < word.Length; ++i) {
                if (!rows[row].Contains(char.ToLower(word[i]))){
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