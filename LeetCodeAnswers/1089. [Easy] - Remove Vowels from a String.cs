//This problem can be found at: https://leetcode.com/problems/remove-vowels-from-a-string

public class Solution {
    public string RemoveVowels(string s) {
        StringBuilder ret = new StringBuilder(s);
        
        int adjuster=0;
        for(int i=0;i<s.Length;i++){
            if(s[i]== 'a'|| s[i]== 'e'|| s[i]== 'i'|| s[i]== 'o'|| s[i]== 'u'){
                ret.Remove(i+adjuster,1);
                adjuster--;
            }
        }
        return Convert.ToString(ret);
                                                      
        
    }
}
