//This problem can be found at: https://leetcode.com/problems/make-array-zero-by-subtracting-equal-amounts

public class Solution {
    public int MinimumOperations(int[] nums) {
        int counter =0;
        int check = notAllZero(nums);
        while(check!=-1){
            int min= nums[check];
            for(int i=check;i<nums.Length;i++){
                if(nums[i]<min && nums[i]!=0) min = nums[i];
            }
            for(int i=0;i<nums.Length;i++){
                if(nums[i]!=0) nums[i]-=min;
            }
            counter++;
           check= notAllZero(nums);
        }
        return counter;
    }
    private int notAllZero(int[] nums){
        for(int i=0;i<nums.Length;i++){
            if(nums[i]!=0)return i;
        }
        return -1;
    }
}
