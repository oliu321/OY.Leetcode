// 98.21% could be improved by using indexOf/substring in . breakup
public class Solution {
    public IList<string> SubdomainVisits(string[] cpdomains) {
        Dictionary<string, int> cnts = new Dictionary<string, int>();
        foreach(var cp in cpdomains) {
            var twoParts = cp.Split(new char[]{' '});
            int cnt = int.Parse(twoParts[0]);
            var parts = twoParts[1].Split(new char[]{'.'});
            string p = parts[parts.Length - 1];
            for(int i = parts.Length - 2; i >= 0; --i){
                if(cnts.ContainsKey(p))
                    cnts[p] = cnts[p] + cnt;
                else
                    cnts[p] = cnt; 
                p = parts[i] + "." + p;
            }
            if(cnts.ContainsKey(p))
                    cnts[p] = cnts[p] + cnt;
                else
                    cnts[p] = cnt;
        }
        
        List<string> l = new List<string>();
        foreach(var ps in cnts)
            l.Add($"{ps.Value} {ps.Key}");
        return l;
    }
}