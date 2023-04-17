//This problem can be found at: https://leetcode.com/problems/binary-search

public class Solution {
    public int Search(int[] nums, int target) {
        int ret= Array.BinarySearch(nums,target);
        if(ret<0) return -1;
        
        return ret;
        
        
    }
}
