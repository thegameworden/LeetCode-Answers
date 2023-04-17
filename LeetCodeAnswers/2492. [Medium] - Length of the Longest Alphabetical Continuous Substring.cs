//This problem can be found at: https://leetcode.com/problems/length-of-the-longest-alphabetical-continuous-substring

public class Solution {
    int longest;
    public int LongestContinuousSubstring(string s) {
        longest=1;
        int pointer=0;
        int temp =1;
       while(pointer<s.Length-1){
           
            if(s[pointer+1]-s[pointer]==1){
                temp++;
            }else{
                temp=1;
            }

             if(longest<temp)
                longest=temp;

            pointer++;
        }

        return longest;
    }
}
/*
"abacaba"


*/
