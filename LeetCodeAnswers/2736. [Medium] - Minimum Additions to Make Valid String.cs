//This problem can be found at: https://leetcode.com/problems/minimum-additions-to-make-valid-string

public class Solution {
    public int AddMinimum(string word) {
        int count =0;

        if(word[0]!='a'){
           // Console.WriteLine((int)(word[0]-'a'));
          //  Console.WriteLine("added from beginning");
            count+= (int)(word[0]-'a');
        }
        
        for(int i=1;i<word.Length;i++){
            char prev = word[i-1];
           // Console.WriteLine($"prev: {prev} -> {word[i]}");
            if(prev==word[i]){
                count+=2;
                continue;
            }
            
            if(prev=='c' && word[i]=='a' || (int)word[i]-(int)prev==1)
                continue;
            
            count++;
            }
         
         return count+ (99-(int)word[word.Length-1]);
        }
    
        
        
        
    }

