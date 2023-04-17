//This problem can be found at: https://leetcode.com/problems/reverse-string

public class Solution {
    public void ReverseString(char[] s) {
        int mid = s.Length/2;
        for(int i=0;i<s.Length/2;i++){
            char temp = s[i];
            s[i]=s[s.Length-i-1];
            s[s.Length-i-1]=temp;
        }
        
    }
}
