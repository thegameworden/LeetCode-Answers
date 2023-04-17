//This problem can be found at: https://leetcode.com/problems/single-number

public class Solution {
    public int SingleNumber(int[] nums) {
        int ret = 0;
        for(int i=0;i<nums.Length;i++){
            ret^= nums[i];
        }
        
        return ret;
    }
}
