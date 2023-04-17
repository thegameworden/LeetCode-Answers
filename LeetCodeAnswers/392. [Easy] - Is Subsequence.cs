//This problem can be found at: https://leetcode.com/problems/is-subsequence

public class Solution {
    public bool IsSubsequence(string s, string t) {
        if(s.Length>t.Length)
        return false;
        if(s.Length==0)
        return true;
        int sPointer=0;
        for(int i=0;i<t.Length;i++){
            if(t[i]== s[sPointer]){
                sPointer++;
                if(sPointer==s.Length)
                return true;
            }
        }

        return false;
        
    }
}
