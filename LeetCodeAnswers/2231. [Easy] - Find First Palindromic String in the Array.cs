//This problem can be found at: https://leetcode.com/problems/find-first-palindromic-string-in-the-array

public class Solution {
    public string FirstPalindrome(string[] words) {
        for(int i=0;i<words.Length;i++){
            if(isPalindrome(words[i]))
            return words[i];
        }

        return "";
    }

    private bool isPalindrome(string word){
        for(int i=0;i<word.Length/2;i++){
            if(word[i]!=word[word.Length-i-1])
            return false;
        }
        return true;
    }
}
