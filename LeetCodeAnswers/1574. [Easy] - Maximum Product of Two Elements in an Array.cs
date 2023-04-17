//This problem can be found at: https://leetcode.com/problems/maximum-product-of-two-elements-in-an-array

public class Solution {
    public int MaxProduct(int[] nums) {
        PriorityQueue<int,int> q = new PriorityQueue<int,int>(Comparer<int>.Create((x, y) => y - x));
        for(int i=0;i<nums.Length;i++){
            q.Enqueue(nums[i],nums[i]);
        }
        return (q.Dequeue()-1)*(q.Dequeue()-1);
    }




}
