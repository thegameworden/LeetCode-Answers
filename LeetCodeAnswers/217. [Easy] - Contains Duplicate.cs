//This problem can be found at: https://leetcode.com/problems/contains-duplicate

public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        HashSet<int> dups = new HashSet<int>();
        for(int i=0;i<nums.Length;i++){
            dups.Add(nums[i]);
        }
        if(dups.Count==nums.Length)
            return false;
        
        return true;
    }
}
