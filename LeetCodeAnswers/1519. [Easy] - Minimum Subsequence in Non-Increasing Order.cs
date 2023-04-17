//This problem can be found at: https://leetcode.com/problems/minimum-subsequence-in-non-increasing-order

public class Solution {
    public IList<int> MinSubsequence(int[] nums) {
        Array.Sort(nums);
        int total = 0;
        for(int i=0;i<nums.Length;i++){
            total+= nums[i];
        }

        int pointer = nums.Length-1;
        int sub =0;
        List<int> ret = new();
        while(sub<= total-sub){
            sub+= nums[pointer];
            ret.Add(nums[pointer]);
            pointer--;
        }

        return ret;



    } 
}
