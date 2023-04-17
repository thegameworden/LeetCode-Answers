//This problem can be found at: https://leetcode.com/problems/count-of-matches-in-tournament

public class Solution {
    public int NumberOfMatches(int n) {
        int matches = 0;
        while(n>1){
            if(n%2==0){
            n/=2;
            matches+=n;
            }else{
                n=(n-1)/2;
                matches+=n+1;
            }
        }

        return matches;
    }
}
