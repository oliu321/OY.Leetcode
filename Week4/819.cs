// Not enough data for percentage
public class Solution {
    public string MostCommonWord(string paragraph, string[] banned) {
        if(string.IsNullOrEmpty(paragraph)) return string.Empty;
        
        string common = string.Empty; int commonCnt = 0;
        Dictionary<string, int> occurence = new Dictionary<string, int>();
        HashSet<string> b = new HashSet<string>(banned);
        int start = 0, end = 0;
        while(end < paragraph.Length){
            if (char.IsLetter(paragraph[end]))
                break;
            ++end;
        }
        start = end;
        ++end;
        string word = null;
        int t = 0;
        while(start < paragraph.Length && end < paragraph.Length){
            if(char.IsLetter(paragraph[end])){
                ++end;
                continue;
            }
                
            word = paragraph.Substring(start, end - start).ToLower();
            t = 0;
            if (!b.Contains(word)){
            if(occurence.ContainsKey(word)){
                t = occurence[word] = occurence[word] + 1;
            }
            else{
                t = occurence[word] = 1;
            }
            if (t > commonCnt){
                commonCnt = t;
                common = word;
            }
            }
        
            while(end < paragraph.Length){
                if (char.IsLetter(paragraph[end]))
                    break;
                ++end;
            }
            start = end;
            ++end;
        }
        if (start < paragraph.Length){
        word = paragraph.Substring(start, end - start).ToLower();
        t = 0;
        if (!b.Contains(word)){
        if(occurence.ContainsKey(word)){
            t = occurence[word] = occurence[word] + 1;
        }
        else{
            t = occurence[word] = 1;
        }
        if (t > commonCnt){
            commonCnt = t;
            common = word;
        }
        }
        }
    
        return common;
    }
}