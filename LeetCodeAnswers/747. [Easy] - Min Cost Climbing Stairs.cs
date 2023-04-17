//This problem can be found at: https://leetcode.com/problems/min-cost-climbing-stairs

public class Solution {
    public int MinCostClimbingStairs(int[] cost) {
      int[] minCost = new int[cost.Length+1];
        
        for(int i=2;i<minCost.Length;i++){
            minCost[i]=Math.Min(minCost[i-2]+cost[i-2],minCost[i-1]+cost[i-1]);
        }
        return minCost[minCost.Length-1];
        
        
    }
}
