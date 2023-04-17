//This problem can be found at: https://leetcode.com/problems/search-insert-position

public class Solution {
    public int SearchInsert(int[] nums, int target) {
        int ret= Array.BinarySearch(nums,target);
        if(ret<0){
            return ~ret;
        }
        return ret;
    }
}
