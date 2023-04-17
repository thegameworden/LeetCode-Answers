//This problem can be found at: https://leetcode.com/problems/reverse-only-letters

using System.Text.RegularExpressions;
public class Solution {
    public string ReverseOnlyLetters(string s) {
        Regex rg = new Regex("[a-zA-Z]");
        Stack<char> rev = new Stack<char>();
        StringBuilder sb = new StringBuilder();
        
        for(int i=0;i<s.Length;i++){
            Console.WriteLine(s[i]);
            if(rg.IsMatch(Char.ToString(s[i]))){
                rev.Push(s[i]);
            }
        }
        
        for(int i=0;i<s.Length;i++){
            if(rg.IsMatch(Char.ToString(s[i]))){
                sb.Append(rev.Pop());
        }else{
                sb.Append(s[i]);
            }
            
        }
        
        return sb.ToString();
        
        
        
       
    }
}
