//This problem can be found at: https://leetcode.com/problems/climbing-stairs

public class Solution {
    public int ClimbStairs(int n) {
        if(n<=2){
            return n;
        }
        
        int[] stairs = new int[n];
        
        stairs[0]=1;
        stairs[1]=2;
        
        for(int i=2;i<n;i++){
            stairs[i]=stairs[i-1]+stairs[i-2];
        }
        return stairs[n-1];
    }
    
}
