//This problem can be found at: https://leetcode.com/problems/two-sum-less-than-k

public class Solution {
    public int TwoSumLessThanK(int[] nums, int k) {
        int ret =-1;
        Array.Sort(nums);
        int pointer=1;
        for(int i=0;i<nums.Length-1;i++){
            for(int j=i+1;j<nums.Length;j++){
                if(nums[i]+nums[j]<k && nums[i]+nums[j]>ret){
                    ret=nums[i]+nums[j];
                  
                }
            }
            }
        return ret;
        
        
    }
}
