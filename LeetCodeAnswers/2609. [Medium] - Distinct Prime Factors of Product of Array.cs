//This problem can be found at: https://leetcode.com/problems/distinct-prime-factors-of-product-of-array

public class Solution {
    public int DistinctPrimeFactors(int[] nums) {
        HashSet<int> primes = new HashSet<int>();
        for(int i=0;i<nums.Length;i++){
          //  Console.WriteLine($"\t Checking for {nums[i]}");
            for(int b=2;nums[i]>1;b++){
                int x=0;
                while(nums[i]%b==0){
                    nums[i]/=b;
                    x++;
                   // Console.WriteLine($"{b} is a factor");
                    primes.Add(b);
                }
                
                //Console.WriteLine($"\t\t The count is now {primes.Count}");
            }
        }
        return primes.Count;
        
    }
}

/*
for (b = 2; a > 1; b++)
    if (a % b == 0)
    {
        int x = 0;
        while (a % b == 0)
        {
            a /= b;
            x++;
        }
        Console.WriteLine($"{b} is a prime factor {x} times!");
    }
*/
