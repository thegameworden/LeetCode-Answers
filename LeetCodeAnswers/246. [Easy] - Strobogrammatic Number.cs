//This problem can be found at: https://leetcode.com/problems/strobogrammatic-number

public class Solution {
    public bool IsStrobogrammatic(string num) {
        Dictionary<char,char> strobo = new Dictionary<char,char>();
        strobo.Add('0','0');
        strobo.Add('1','1');
        strobo.Add('8','8');
        strobo.Add('6','9');
        strobo.Add('9','6');
        
        
        for(int i=0;i<=num.Length/2;i++){
            if(!strobo.ContainsKey(num[i]) || !strobo.ContainsKey(num[num.Length-1-i]))
                return false;
            
            if(num[i]!= strobo[num[num.Length-1-i]]||num[num.Length-1-i]!= strobo[num[i]])
                return false;
                
        }
        return true;
    }
}
