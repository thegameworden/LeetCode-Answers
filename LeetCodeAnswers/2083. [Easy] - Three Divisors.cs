//This problem can be found at: https://leetcode.com/problems/three-divisors

public class Solution {
    public bool IsThree(int n) {
        if(n<3)
        return false;

        bool foundThird=false;
        for(int i=2;i<=n/2;i++){
            if(n%i==0){
                if(foundThird)
                return false;

                foundThird=true;
            }
        }
        if(foundThird)
        return true;

        return false;
        
    }
}
