//This problem can be found at: https://leetcode.com/problems/maximum-ice-cream-bars

public class Solution {
    public int MaxIceCream(int[] costs, int coins) {
        PriorityQueue<int,int> iceCream = new PriorityQueue<int,int>(Comparer<int>.Create((x, y) => x.CompareTo(y)));
        for(int i=0;i<costs.Length;i++){
            iceCream.Enqueue(costs[i],costs[i]);
        }
        int bars=0;
        while(iceCream.Count!=0){
            int next= iceCream.Dequeue();
        
            if(next>coins)
            return bars;

            bars++;
            coins-=next;
        }

        return bars;
    }
}
