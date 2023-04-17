//This problem can be found at: https://leetcode.com/problems/single-element-in-a-sorted-array

public class Solution {
    public int SingleNonDuplicate(int[] nums) {
        int temp=0;
        for(int i=0;i<nums.Length;i++){
            temp^=nums[i];
        }
        return temp;
    }
}
