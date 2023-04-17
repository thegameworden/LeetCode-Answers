//This problem can be found at: https://leetcode.com/problems/isomorphic-strings

public class Solution {
    public bool IsIsomorphic(string s, string t) {
        Dictionary<char,char> iso = new Dictionary<char,char>();
        for(int i=0;i<s.Length;i++){
            if(iso.ContainsKey(s[i])){
                if(iso[s[i]]!= t[i]){
                    return false;
                }
            }else{
            if(iso.ContainsValue(t[i])){
              //  Console.WriteLine("test");
                return false;
            }
            iso.Add(s[i],t[i]);
            }
            
        }
        
        return true;
    }
}
