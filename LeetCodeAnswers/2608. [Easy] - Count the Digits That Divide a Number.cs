//This problem can be found at: https://leetcode.com/problems/count-the-digits-that-divide-a-number

public class Solution {
    public int CountDigits(int num) {
        int counter = 0;
        int test = num;
        while(test>0){
            int temp = test%10;
            if(num%temp==0)
                counter++;
            
            test/=10;
        }
        return counter;
    }
}
