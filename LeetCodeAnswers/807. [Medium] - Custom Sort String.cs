//This problem can be found at: https://leetcode.com/problems/custom-sort-string

public class Solution {
    public string CustomSortString(string order, string s) {
        List<char> ret = new List<char>();
       
        for(int i=0;i<order.Length;i++){
       for(int j=0;j<s.Length;j++){
           if(s[j]== order[i]){
               ret.Add(s[j]);
           }
       }
        
        }
        
        for(int i=0;i<s.Length;i++){
            if(!order.Contains(s[i])){
                ret.Add(s[i]);
            }
        }
        
        
        
        
        
        
        return new string(ret.ToArray());
    }
}
