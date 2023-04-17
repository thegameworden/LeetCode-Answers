//This problem can be found at: https://leetcode.com/problems/count-equal-and-divisible-pairs-in-an-array

public class Solution {
    public int CountPairs(int[] nums, int k) {
        int pairs=0;
        for(int i=0;i<nums.Length-1;i++){
            for(int j=i+1;j<nums.Length;j++){
                if(nums[i]==nums[j] && (i*j)%k==0)
                pairs++;
            }
        }
        return pairs;
    }
}
