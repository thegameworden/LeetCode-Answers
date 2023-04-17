//This problem can be found at: https://leetcode.com/problems/sum-of-number-and-its-reverse

public class Solution {
    public bool SumOfNumberAndReverse(int num) {
        for(int i=0;i<=num;i++){
            int  rev = reverse(i);
            if(i+rev==num)
            return true;
        }
        return false;
    }

    public int reverse(int num){
        int ret = 0;
        while(num>0){
            ret*=10;
            ret+=num%10;
            num/=10;
        }
        return ret;
    }
}
