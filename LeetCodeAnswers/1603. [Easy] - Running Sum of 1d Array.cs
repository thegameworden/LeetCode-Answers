//This problem can be found at: https://leetcode.com/problems/running-sum-of-1d-array

public class Solution {
    public int[] RunningSum(int[] nums) {
        int[] ret = new int[nums.Length];
        int sum=0;
        for(int i=0;i<nums.Length;i++){
            sum+=nums[i];
            ret[i]=sum;
        }
        return ret;
    }

}
