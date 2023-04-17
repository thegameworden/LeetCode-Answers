//This problem can be found at: https://leetcode.com/problems/check-if-two-string-arrays-are-equivalent

public class Solution {
    public bool ArrayStringsAreEqual(string[] word1, string[] word2) {
        List<char> w1 = new List<char>();
        List<char> w2 = new List<char>();

        foreach(string s in word1){
            foreach(char c in s){
                w1.Add(c);
            }
        }
        foreach(string s in word2){
            foreach(char c in s){
                w2.Add(c);
            }
        }

        if(w1.Count!=w2.Count)
        return false;

        for(int i=0;i<w1.Count;i++){
            if(w1[i]!=w2[i])
            return false;
        }

        return true;

    }
}
