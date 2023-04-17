//This problem can be found at: https://leetcode.com/problems/minimum-cost-of-buying-candies-with-discount

public class Solution {
    public int MinimumCost(int[] cost) {
        PriorityQueue<int,int> q = new();
        for(int i=0;i<cost.Length;i++){
            q.Enqueue(cost[i],-cost[i]);
        }
        int min=0;
        while(q.Count>=3){
            min += q.Dequeue();
            min+=q.Dequeue();
            q.Dequeue();
        }

        while(q.Count!=0){
            min+=q.Dequeue();
        }
        return min;

    }
}
