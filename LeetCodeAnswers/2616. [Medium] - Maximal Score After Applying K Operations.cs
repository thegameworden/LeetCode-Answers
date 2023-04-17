//This problem can be found at: https://leetcode.com/problems/maximal-score-after-applying-k-operations

public class Solution {
    public long MaxKelements(int[] nums, int k) {
      
        PriorityQueue<int,int> q = new(Comparer<int>.Create((x, y) => y - x));
        for(int i=0;i<nums.Length;i++){
            q.Enqueue(nums[i],nums[i]);
        }
        
         long score=0;
        for(int i=0;i<k;i++){
            if(q.Count!=0){
            int adder = q.Dequeue();
            int reQ = (int) Math.Ceiling((decimal)adder/3);
                
            score+=adder;
            q.Enqueue(reQ,reQ);        
        
                
            }
        }
        
            
        return score;
    }
}
