//This problem can be found at: https://leetcode.com/problems/remove-element

public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int latestNonVal=0;
        int size= nums.Length;
        for(int i=0;i<nums.Length;i++){
            if(nums[i]!=val){
                
                nums[latestNonVal]=nums[i];
                latestNonVal++;
            }else{
                size--;
            }
        }
        return size;
    }
}
