//This problem can be found at: https://leetcode.com/problems/valid-parentheses

public class Solution {
    public bool IsValid(string s) {
        Stack<char> input = new Stack<char>();
        
        HashSet<char> open= new HashSet<char>();
        open.Add('(');
        open.Add('[');
        open.Add('{');
        HashSet<char> close = new HashSet<char>();
        close.Add(')');
        close.Add(']');
        close.Add('}');
        
        for(int i=0;i<s.Length;i++){
            if(open.Contains(s[i])){
                input.Push(s[i]);
            }else{
                if(input.Count==0)
                    return false;
                
                if(valid(input.Peek(),s[i])){
                    input.Pop();
                }else{return false;}
            }
        }
        
        if(input.Count!=0)
            return false;
        
        return true;
        
    }
    
    private bool valid(char peek, char input){
        if((peek=='('&& input == ')')||(peek=='{'&& input == '}')||(peek=='['&& input == ']'))
            return true;
        return false;
    }
}
