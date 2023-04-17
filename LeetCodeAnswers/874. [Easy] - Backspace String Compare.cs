//This problem can be found at: https://leetcode.com/problems/backspace-string-compare

public class Solution {
    public bool BackspaceCompare(string s, string t) {
        StringBuilder stringS = new StringBuilder();
        for(int i=0;i<s.Length;i++){
            if(s[i]== '#'){
                if(stringS.Length ==0){
                    continue;
                }
                
                stringS.Remove(stringS.Length-1,1);
            }else{
            
            stringS.Append(s[i]);
            }
        }
        
        StringBuilder stringT = new StringBuilder();
        for(int i=0;i<t.Length;i++){
            if(t[i]== '#'){
                if(stringT.Length ==0){
                    continue;
                }
                
                stringT.Remove(stringT.Length-1,1);
            }else{
            stringT.Append(t[i]);
            }
        }
        
        
        if(!stringT.Equals(stringS)){
            return false;
        }
        return true;
        
        
            
            
    }
}
