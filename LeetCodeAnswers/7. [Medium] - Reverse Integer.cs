//This problem can be found at: https://leetcode.com/problems/reverse-integer

public class Solution {
    public int Reverse(int x) {
        int reverse=0;
        int pop;
        while(x!=0){
            pop = x%10;
            x=x/10;
            if (reverse > Int32.MaxValue/10 || (reverse == Int32.MaxValue / 10 && pop > 7)) return 0;
            if (reverse < Int32.MinValue/10 || (reverse == Int32.MinValue / 10 && pop < -8)) return 0;
            reverse = reverse * 10 + pop;
            
        }
        return reverse;
    }
}
