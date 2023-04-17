//This problem can be found at: https://leetcode.com/problems/subtract-the-product-and-sum-of-digits-of-an-integer

public class Solution {
    public int SubtractProductAndSum(int n) {
        int prod=1;
        int sum=0;
         int digit=0;
        while(n>0){
            digit= n%10;
            prod*=digit;
            sum+=digit;
            n/=10;
        }
        return prod-sum;
    }
}
