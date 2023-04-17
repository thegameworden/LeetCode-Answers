//This problem can be found at: https://leetcode.com/problems/remove-outermost-parentheses

public class Solution {
    public string RemoveOuterParentheses(string s) {
        Stack<char> prim = new();
        StringBuilder strb = new StringBuilder();
        StringBuilder ret = new StringBuilder();
        for(int i=0;i<s.Length;i++){
            //Console.WriteLine($"{s[i]}  {strb.Length}");
            if(prim.Count==0 && strb.Length !=0){
              //  Console.WriteLine(strb.ToString());
                strb.Remove(0,1);
                strb.Remove(strb.Length-1,1);
                ret.Append(strb.ToString());
                strb= new StringBuilder();
            }
                strb.Append(s[i]);
                if(s[i]=='('){
                    prim.Push('(');
                }else{
                    prim.Pop();
                }
        }
        if(strb.Length!=0){
         strb.Remove(0,1);
                strb.Remove(strb.Length-1,1);
                ret.Append(strb.ToString());
                strb= new StringBuilder();
        
        }
        
        return ret.ToString();
    }
}
