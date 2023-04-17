//This problem can be found at: https://leetcode.com/problems/find-the-longest-balanced-substring-of-a-binary-string

public class Solution {
    public int FindTheLongestBalancedSubstring(string s) {
        int longest=0;
        for(int i=0;i<s.Length-1;i++){
            if(s[i]=='1')continue;
            int counter=1;
            bool one = false;
            for(int j=i+1;j<s.Length;j++){
               // Console.WriteLine(s[j]);
                if(s[j]=='0'){
                    if(!one){
                    counter++;
                    }else{
                    break;
                    }
                    
                }else if(s[j]=='1'){
                   // Console.WriteLine($"found a 1, counter is currently {counter}");
                    counter--;
                    one=true;
                    if(counter==0){
                       // Console.WriteLine($"Possible answer of range [{i} - {j}]");
                        longest=Math.Max(longest,j-i+1);
                    }
                }else{
                    break;
                }
                
                
                
            }
        }
       // Console.WriteLine("-------------");
        
        return longest;
    }
}
