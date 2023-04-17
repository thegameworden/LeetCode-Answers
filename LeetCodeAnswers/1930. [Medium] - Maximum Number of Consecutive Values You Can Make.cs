//This problem can be found at: https://leetcode.com/problems/maximum-number-of-consecutive-values-you-can-make

public class Solution {
    public int GetMaximumConsecutive(int[] coins) {
       Array.Sort(coins);
       if(coins[0]>1) return 1;
       int sum = coins[0];
        for(int i=1;i<coins.Length;i++){
            if(coins[i] >sum+1) break;
            sum+= coins[i];
        }

        return sum+1;
    }

}
