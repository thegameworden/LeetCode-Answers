//This problem can be found at: https://leetcode.com/problems/prime-in-diagonal

public class Solution {
    public int DiagonalPrime(int[][] nums) {
        List<int> primes = new();
        for(int i=0;i<nums.Length;i++){
            
            if(isPrime(nums[i][i])) primes.Add(nums[i][i]);
            
            if(isPrime(nums[i][nums.Length-1-i])) primes.Add(nums[i][nums.Length-1-i]);
        }
        
        if(primes.Count==0)return 0;
        
        int max=0;
        for(int i=0;i<primes.Count;i++){
            if(max<primes[i])
                max=primes[i];
        }
        
     
        return max;
    }
    
    private bool isPrime(int i){
        if(i<2) return false;
        

        for(int j=2;j<=(int)Math.Floor(Math.Sqrt(i));j++){
            
            if(i%j==0)return false;
        }
        
        return true;
    }
}
