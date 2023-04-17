//This problem can be found at: https://leetcode.com/problems/license-key-formatting

public class Solution {
    public string LicenseKeyFormatting(string s, int k) {
        string str = s.Replace("-","").ToUpper();
        int rem = str.Length % k;
        int dashes = str.Length/k;
        int pointer;
        if(rem==0){
            pointer=k;
        }else{
            pointer=rem;
        }
        while(pointer<str.Length){
            str=str.Insert(pointer,"-");
            pointer+=k+1;
        }
        
        return str;
        
        
    }
}
