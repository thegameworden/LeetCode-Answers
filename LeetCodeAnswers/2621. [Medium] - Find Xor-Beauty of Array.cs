//This problem can be found at: https://leetcode.com/problems/find-xor-beauty-of-array

public class Solution {
    public int XorBeauty(int[] nums) {
        int beauty=0;
        for(int i=0;i<nums.Length;i++){
            beauty^=nums[i];
        }

        return beauty;
    }
}
