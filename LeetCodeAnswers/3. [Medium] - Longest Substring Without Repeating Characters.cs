//This problem can be found at: https://leetcode.com/problems/longest-substring-without-repeating-characters

public class Solution {
    public int LengthOfLongestSubstring(string s) {
        Dictionary<char,int> test= new Dictionary<char,int>();
        int count=0;
        int temp=0;
        
        
        if(s.Length ==1){
            return 1;
        }
        
        for(int i=0;i<s.Length;i++){
            Console.WriteLine(s[i]);
            for(int k=i;k<s.Length;k++){
              if(!test.ContainsKey(s[k])){
                  test.Add(s[k],1);
                  temp++;
              }else{
                  test.Clear();
                  if(temp>count){
                      count=temp;
                  }
                  temp=0;
                  break;
              }
                
                   }
                   
               }
                  
             return count;    
            }
               
        }
        
