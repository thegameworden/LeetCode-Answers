//This problem can be found at: https://leetcode.com/problems/maximum-value-after-insertion

public class Solution {
    public string MaxValue(string n, int x) {
        
        StringBuilder ret = new StringBuilder();
        if(n.Length==1){
            if(Convert.ToInt32(n)-48<x){
                ret.Append(n);
                ret.Append(Convert.ToString(x));
                return ret.ToString();
            }
            ret.Append(Convert.ToString(x));
            ret.Append(n);
            return ret.ToString();
        }
        bool neg = n[0]=='-';
        int start=0;
        if(neg){
            ret.Append(n[start]);
            start++;
            while(start<n.Length){
                Console.WriteLine(Convert.ToInt32(n[start])-48);
                
            if(Convert.ToInt32(n[start])-48<=x){
                Console.WriteLine(n[start]);
                ret.Append(n[start]);
                start++;
            }else{
                break;
            }
            
        }
            ret.Append(x);
            ret.Append(n.Substring(start,n.Length-start));
            return ret.ToString();
        }

        while(start<n.Length){
              if(Convert.ToInt32(n[start])-48>=x){
                  ret.Append(n[start]);
                  start++;
              }else{
                  break;
              }
        }

          ret.Append(x);
            ret.Append(n.Substring(start,n.Length-start));
            return ret.ToString();

    }
}
