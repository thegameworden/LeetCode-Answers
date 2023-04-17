//This problem can be found at: https://leetcode.com/problems/largest-substring-between-two-equal-characters

public class Solution {
    public int MaxLengthBetweenEqualCharacters(string s) {
        int max = -1;
        for(int i=0;i<s.Length-1;i++){
            for(int j=i+1;j<s.Length;j++){
                if(s[i]==s[j] && (j-i-1)>max)
                max = j-i-1;
            }
        }

        return max;
    }
}
