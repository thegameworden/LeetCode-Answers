//This problem can be found at: https://leetcode.com/problems/valid-palindrome-ii

public class Solution {
    public bool ValidPalindrome(string s) {
        int i=0;
        int j=s.Length-1;
        
        while(i<j){
            if(s[i]!= s[j]){
                return checker(s,i+1,j) || checker(s,i,j-1);
            }
            i++;
            j--;
        }
        
        return true;
    }
    
    private bool checker(string s, int i, int j){
        while(i<j){
            if(s[i]!= s[j]){
                return false;
            }
            i++;
            j--;
        }
        return true;
    }
}
