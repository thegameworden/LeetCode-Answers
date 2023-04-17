//This problem can be found at: https://leetcode.com/problems/roman-to-integer

public class Solution {
    public int RomanToInt(string s) {
        Dictionary<char,int> romanConvert = new Dictionary<char,int>();
        romanConvert.Add('M',1000);
        romanConvert.Add('D',500);
        romanConvert.Add('C',100);
        romanConvert.Add('L',50);
        romanConvert.Add('X',10);
        romanConvert.Add('V',5);
        romanConvert.Add('I',1);
        
        
        int ret = romanConvert[s[0]];
        if(s.Length==1){
            return ret;
        }
        
        
        for(int i=1;i<s.Length;i++){
            Console.WriteLine($"Current total: {ret}");
            Console.WriteLine(romanConvert[s[i]]);
            if(romanConvert[s[i-1]]<romanConvert[s[i]]){
               Console.WriteLine("subtracting");
                ret-=2*(romanConvert[s[i-1]]);
                ret+=romanConvert[s[i]];
            }else{
                Console.WriteLine("adding");
                ret+=romanConvert[s[i]];
            }
        }
        
        return ret;
    }
}
