//This problem can be found at: https://leetcode.com/problems/calculate-digit-sum-of-a-string

public class Solution {
    public string DigitSum(string s, int k) {
        while(s.Length>k){
           // Console.WriteLine(s.Length);
            s=sumString(s,k);
        }
        
        return s;
        
    }
    
    
    
    private string sumString(string s, int k){
        StringBuilder sb = new StringBuilder();
        List<string> list = new List<string>();
        int pointer=0;
       while(pointer<s.Length){
            if(pointer+k>s.Length){
                list.Add(s.Substring(pointer, s.Length-pointer));
                break;
            }
            list.Add(s.Substring(pointer,k));
            pointer+=k;
        }
        
        
        foreach(string str in list){
         int adder = 0;
            for(int i=0;i<str.Length;i++){
                int temp;
                Int32.TryParse(str[i].ToString(), out temp);
                adder+=temp;
         }
            sb.Append(adder);
        }
        return sb.ToString();
        
        
    }
}
