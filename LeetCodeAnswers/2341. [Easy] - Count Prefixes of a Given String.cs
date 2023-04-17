//This problem can be found at: https://leetcode.com/problems/count-prefixes-of-a-given-string

public class Solution {
    public int CountPrefixes(string[] words, string s) {
       int count=0;
        for(int i=0;i<words.Length;i++){
            if(s.StartsWith(words[i])) count++;
        }

        return count;
    }
}
