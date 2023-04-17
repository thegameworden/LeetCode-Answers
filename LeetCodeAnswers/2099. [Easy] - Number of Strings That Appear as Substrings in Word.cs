//This problem can be found at: https://leetcode.com/problems/number-of-strings-that-appear-as-substrings-in-word

public class Solution {
    public int NumOfStrings(string[] patterns, string word) {
        int count=0;
        for(int i=0;i<patterns.Length;i++){
            if(word.IndexOf(patterns[i])!=-1) count++;
        }
        return count;
    }
}
