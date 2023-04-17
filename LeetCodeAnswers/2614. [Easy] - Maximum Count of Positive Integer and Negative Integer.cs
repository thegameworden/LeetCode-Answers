//This problem can be found at: https://leetcode.com/problems/maximum-count-of-positive-integer-and-negative-integer

public class Solution {
    public int MaximumCount(int[] nums) {
        List<int> lst = new List<int>();
        for(int i=0;i<nums.Length;i++){
            if(nums[i]!=0)
                lst.Add(nums[i]);
        }
        
        int left=0;
        int right = lst.Count-1;
        while(left<=right){
            int middle = (left+right)/2;
            if(nums[middle]<0){
                left=middle+1;
            }else{
                right=middle-1;
            }
        }
        
        
        return Math.Max(left, lst.Count-left);
    }
}
