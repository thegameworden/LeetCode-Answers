//This problem can be found at: https://leetcode.com/problems/armstrong-number

public class Solution {
    public bool IsArmstrong(int n) {
        string num = n.ToString();
        int size = num.Length;
        
        int temp=0;
        for(int i=0;i<size;i++){
            temp+= (int)Math.Pow(int.Parse(num[i].ToString()),size);
        }
        if(temp==n)
            return true;
                            
        return false;
        
        
    }
}
