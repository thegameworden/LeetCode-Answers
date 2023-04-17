//This problem can be found at: https://leetcode.com/problems/powx-n

public class Solution {
    public double MyPow(double x, int n) {
        /*
        if(n==0){
            return 1;
        }
        
        double ret=1;
        for(int i=1;i<=Math.Abs(n);i++){
            ret=ret*x;
        }
        
        if(n<0){
            ret=1/ret;
        }
        
        return ret;
    */
        
        return Math.Pow(x, (double)n);
    }
}
