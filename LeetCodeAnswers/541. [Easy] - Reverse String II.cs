//This problem can be found at: https://leetcode.com/problems/reverse-string-ii

public class Solution {
    public string ReverseStr(string s, int k) {
      char[] val = s.ToArray();
    
        
        
        int length = s.Length;
        if(length== 2*k){
            Array.Reverse(val,0,k);
            return new string(val);
        }
        
        int position=0;
        
        
        while(position<length-2*k){
            Array.Reverse(val, position,k);
            position= position+2*k;
            
        }
        
        if(length-position<k){
            Array.Reverse(val,position,length-position);
            
        }
        if(length-position<2*k &&length-position>=k){
            Console.WriteLine("test");
            Array.Reverse(val, position,k);
        }
        
        
        
        return new string(val);
    }
}
