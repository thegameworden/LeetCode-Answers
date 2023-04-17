//This problem can be found at: https://leetcode.com/problems/replace-all-digits-with-characters

public class Solution {
    public string ReplaceDigits(string s) {
        if(s.Length==1)
        return s;
        StringBuilder sb = new StringBuilder(s);
        for(int i=1;i<s.Length;i+=2){
            //Console.WriteLine($"{(char)(s[i]+s[i-1]-48)}");
            sb[i]=(char)(s[i]+s[i-1]-48);
        }
        return sb.ToString();
    }
}
