//This problem can be found at: https://leetcode.com/problems/word-pattern

public class Solution {
    public bool WordPattern(string pattern, string s) {
        
        string[] arr = s.Split(' ');
        if(pattern.Length!=arr.Length)
        return false;
        Dictionary<char, string> patt = new();

        for(int i=0;i<pattern.Length;i++){
            if(patt.ContainsKey(pattern[i])){
                 if(patt[pattern[i]]!=arr[i])
                return false;
            }else if(patt.ContainsValue(arr[i])){
                return false;
            }
            else{
                patt.Add(pattern[i],arr[i]);
            }
        }

        return true;
    }
}
