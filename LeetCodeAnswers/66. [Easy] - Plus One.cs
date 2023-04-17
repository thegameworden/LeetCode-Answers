//This problem can be found at: https://leetcode.com/problems/plus-one

public class Solution {
    public int[] PlusOne(int[] digits) {
        List<int> ret = new List<int>();
        Array.Reverse(digits);
        
        digits[0]++;
        int carry=0;
        for(int i=0;i<digits.Length;i++){
            if(digits[i]+carry>=10){
                
                digits[i]=(digits[i]+carry)%10;
                carry=1;
            }else{
                digits[i]+=carry;
                carry=0;
            }
            ret.Add(digits[i]);
        }
        
        if(carry==1)
            ret.Add(1);
        
        int[] retArr=  ret.ToArray();
        Array.Reverse(retArr);
        return retArr;
        
    

    }
}
