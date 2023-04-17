//This problem can be found at: https://leetcode.com/problems/take-gifts-from-the-richest-pile

public class Solution {
    public long PickGifts(int[] gifts, int k) {
        PriorityQueue<int,int> piles = new(); 
        long ret = 0;
        for(int i=0;i<gifts.Length;i++){
            piles.Enqueue(i,-gifts[i]);
            ret+= gifts[i];
        }
        for(int i=0;i<k;i++){
            int takeFrom= piles.Dequeue();
            ret-=gifts[takeFrom];
            gifts[takeFrom]= (int)Math.Sqrt(gifts[takeFrom]);
            ret+=gifts[takeFrom];
            piles.Enqueue(takeFrom,-gifts[takeFrom]);
        }
        
        return ret;
    }
}
