//This problem can be found at: https://leetcode.com/problems/di-string-match

public class Solution {
    public int[] DiStringMatch(string s) {
        int[] ret = new int[s.Length+1];
        int low=0;
        int high = s.Length;
        for(int i=0;i<s.Length;i++){
            if(s[i]=='I'){
                ret[i]=low;
                low++;
            }else{
                ret[i]=high;
                high--;
            }
        }
        ret[ret.Length-1]= high;
        return ret;
    }
}
