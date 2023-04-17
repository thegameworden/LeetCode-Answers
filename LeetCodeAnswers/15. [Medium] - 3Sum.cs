//This problem can be found at: https://leetcode.com/problems/3sum

public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        List<IList<int>> res = new List<IList<int>>();
        for(int i=0;i<nums.Length;i++){
            if(i==0||nums[i-1]!=nums[i]){
                twoSum(nums,i,res);
            }
        }
        return res;
    }
    
    private void twoSum(int[] nums, int i, List<IList<int>> res){
        int lo = i+1;
        int hi = nums.Length-1;
        while(lo<hi){
        int sum= nums[i]+nums[lo]+nums[hi];
        if(sum<0) lo++;
            else if(sum>0)hi--;
            else{
                List<int> adder = new List<int>();
                adder.Add(nums[i]);
                adder.Add(nums[lo++]);
                adder.Add(nums[hi--]);
                res.Add(adder);
                
                while(lo<hi && nums[lo]== nums[lo-1]){
                    lo++;
                }
            }
        }
        
    }
}
