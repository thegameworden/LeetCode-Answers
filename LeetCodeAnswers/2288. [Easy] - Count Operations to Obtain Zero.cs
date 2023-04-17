//This problem can be found at: https://leetcode.com/problems/count-operations-to-obtain-zero

public class Solution {
    public int CountOperations(int num1, int num2) {
        //int counter= 0;
        return driver(0,num1,num2);
        
    }
    
    private int driver(int counter, int num1, int num2){
        if(num1 ==0 || num2 == 0){
            return counter;
        }
        
        if(num1>=num2){
            num1-=num2;
            counter++;
            
        }else{
            num2-=num1;
            counter++;
           
        }
         return driver(counter,num1,num2);
       
        
    }
}
