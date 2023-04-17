//This problem can be found at: https://leetcode.com/problems/valid-anagram

public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length)
            return false;
        
        char[] sArr= s.ToArray();
        char[] tArr= t.ToArray();
        
        Array.Sort(sArr);
        Array.Sort(tArr);
        
        for(int i=0;i<sArr.Length;i++){
            if(sArr[i]!= tArr[i])
                return false;
        }
        
        return true;
    }
}
