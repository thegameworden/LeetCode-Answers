//This problem can be found at: https://leetcode.com/problems/circular-sentence

public class Solution {
    public bool IsCircularSentence(string sentence) {
        string[] words = sentence.Split(' ');
        for(int i=0;i<words.Length-1;i++){
            if(!words[i].EndsWith(words[i+1][0]))
                return false;
        }
        
        if(words[words.Length-1].EndsWith(words[0][0]))
            return true;
        
        return false;
    }
}
