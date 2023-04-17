//This problem can be found at: https://leetcode.com/problems/occurrences-after-bigram

public class Solution {
    public string[] FindOcurrences(string text, string first, string second) {
        string[] words = text.Split(' ');
        
        List<string> ret= new List<string>();
        if(words.Length<=2){
            return ret.ToArray();
        }
        for(int i=0;i<words.Length-2;i++){
            if(words[i]==first && words[i+1]==second){
                ret.Add(words[i+2]);
            }
        }
        return ret.ToArray();
    }
}
