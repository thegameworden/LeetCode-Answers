//This problem can be found at: https://leetcode.com/problems/power-of-two

public class Solution {
    public bool IsPowerOfTwo(int n) {
        if(n<=0)
            return false;
        
        String binary = Convert.ToString(n,2);
        
        if(binary.LastIndexOf("1")>0){
            return false;
        }
        return true;
    }
}
