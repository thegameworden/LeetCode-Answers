//This problem can be found at: https://leetcode.com/problems/find-pivot-index

public class Solution {
    public int PivotIndex(int[] nums) {

        int left =0;
        int right = 0;
        for(int i=0;i<nums.Length;i++){
            right+=nums[i];
        }
        
        
        for(int i=0;i<nums.Length;i++){
            if(left==right-left-nums[i])
            return i;

            left+=nums[i];
        }
        return -1;

    }
}
