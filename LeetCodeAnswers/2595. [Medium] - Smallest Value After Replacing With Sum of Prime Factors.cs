//This problem can be found at: https://leetcode.com/problems/smallest-value-after-replacing-with-sum-of-prime-factors

public class Solution {
    public int SmallestValue(int n) {
        int oldN = n;
        bool isPrime=true;
        for(int i=2;i<=Math.Sqrt(n);i++){
            
            if(n%i==0){
                isPrime=false;
                break;
            }
        }
        if(isPrime){
      //      Console.WriteLine($"{n} is prime");
            return n;
        }
        
        
        int newN=0;
        while(n>0){
            bool wasFactored=false;
            for(int i=2;i<=Math.Sqrt(n);i++){
                // Console.WriteLine($"{n}%{i}= {n%i}");
                if(n%i==0){
                   
                    newN+=i;
                  //  Console.WriteLine($"newN now is {newN}");
                    n/=i;
                  //  Console.WriteLine($"n now is {n}");
                    wasFactored=true;
                    break;
                }
            }
            if(!wasFactored){
                newN+=n;
                break;
            }
            
           
        }
        if(newN==oldN)
            return oldN;
         return SmallestValue(newN);

        
        
    }
}
