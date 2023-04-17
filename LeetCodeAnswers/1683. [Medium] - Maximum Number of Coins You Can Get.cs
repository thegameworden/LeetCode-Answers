//This problem can be found at: https://leetcode.com/problems/maximum-number-of-coins-you-can-get

public class Solution {
    public int MaxCoins(int[] piles) {
        Array.Sort(piles);
        int max = 0;
        for(int i=piles.Length-2;i>=piles.Length/3;i-=2){
            max+=piles[i]; 
        }

        return max;
    }
}
