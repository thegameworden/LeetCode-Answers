//This problem can be found at: https://leetcode.com/problems/palindrome-number

public class Solution {
    public bool IsPalindrome(int x) {
        int num = x;
        int digit;
        int reverse=0;
        
        while(num>0){
            digit = num%10;
            reverse=reverse*10 +digit;
            num=num/10;
        }
        
        
        Console.WriteLine(reverse);
        if(x==reverse)
            return true;
        
        return false;
        
    }
}
