//This problem can be found at: https://leetcode.com/problems/third-maximum-number

public class Solution {
    public int ThirdMax(int[] nums) {
        HashSet<int> mySet = new HashSet<int>();
        Array.Sort(nums);
        
        for(int i=0;i<nums.Length;i++){
            mySet.Add(nums[i]);
        }
        int[] ret = mySet.ToArray();
        if(ret.Length<3){
            return ret[ret.Length-1];
        }
        
        return ret[ret.Length-3];
        
    }
}
