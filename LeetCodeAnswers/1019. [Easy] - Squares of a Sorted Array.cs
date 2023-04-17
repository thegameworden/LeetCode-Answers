//This problem can be found at: https://leetcode.com/problems/squares-of-a-sorted-array

public class Solution {
    public int[] SortedSquares(int[] nums) {
        for(int i=0;i<nums.Length;i++){
            nums[i]*=nums[i];
        }
        Array.Sort(nums);
        return nums;
    }
}
