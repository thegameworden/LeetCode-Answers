//This problem can be found at: https://leetcode.com/problems/missing-number

public class Solution {
    public int MissingNumber(int[] nums) {
        int n = nums.Length;
       int total= 0;
       for(int i=0;i<nums.Length;i++)
        total+=nums[i];

        return  (n*(n+1)/2)-total;
    }
}
