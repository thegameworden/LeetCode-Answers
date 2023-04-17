//This problem can be found at: https://leetcode.com/problems/two-sum

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> db = new Dictionary<int, int>();
        for(int i=0;i<nums.Length;i++){
            if(db.ContainsKey(nums[i])){
                return new int[] {db[nums[i]], i};
            }else if(db.ContainsKey(target-nums[i])){
                continue;
            }else{
                db.Add(target-nums[i],i);
            }
        }
        
        return new int[2];
    }
}
