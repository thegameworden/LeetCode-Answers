//This problem can be found at: https://leetcode.com/problems/calculate-amount-paid-in-taxes

public class Solution {
    public double CalculateTax(int[][] brackets, int income) {
        double tax = 0;
        int pointer=0;
        int lower=0;
        while(income>0){
           if(income-brackets[pointer][0]+lower<=0){
               
               tax+=income*((double)brackets[pointer][1]/100);
               break;
           }else{
            tax+=(brackets[pointer][0]-lower)*((double)brackets[pointer][1]/100);
            income-=brackets[pointer][0]-lower;
           }

           Console.WriteLine($"Money leftover: {income}");
           lower=brackets[pointer][0];
           pointer++;

        }
        return tax;



    }
}
/*
[12,25]
[7,10]
[3,50] 

7
*/
