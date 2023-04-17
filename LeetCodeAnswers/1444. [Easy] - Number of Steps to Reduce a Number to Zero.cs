//This problem can be found at: https://leetcode.com/problems/number-of-steps-to-reduce-a-number-to-zero

public class Solution {
    public int NumberOfSteps(int num) {
        int steps =0;
        while(num>0){
            if(num%2==0){
                num/=2;
        }else{
            num--;
        }
            steps++;
        }
        
        return steps;
    }
}
