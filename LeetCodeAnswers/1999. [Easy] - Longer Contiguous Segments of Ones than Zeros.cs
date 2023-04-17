//This problem can be found at: https://leetcode.com/problems/longer-contiguous-segments-of-ones-than-zeros

public class Solution {
    public bool CheckZeroOnes(string s) {
        int longestOne= 0;
        int longestZero=0;
        bool isOne=false;
        int counter=0;
        for(int i=0;i<s.Length;i++){
           if((isOne && s[i]=='1') || (!isOne && s[i]=='0')){
               counter++;
           }else{
               if(isOne && counter>longestOne)longestOne=counter;
                if(!isOne && counter>longestZero)longestZero=counter;
               counter=0;
                i--;
                isOne= !isOne;
           }
            
        }
        if(counter!=0){
             if(isOne && counter>longestOne)longestOne=counter;
                if(!isOne && counter>longestZero)longestZero=counter;
        }
        return longestOne>longestZero;
    }
}
