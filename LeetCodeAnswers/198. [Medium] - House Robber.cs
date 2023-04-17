//This problem can be found at: https://leetcode.com/problems/house-robber

public class Solution {
     Dictionary<int,int> maxes = new Dictionary<int,int>();
    public int Rob(int[] nums) {
       if(nums.Length==1){
            return nums[0];
        }
        if(nums.Length==2){
            return Math.Max(nums[0],nums[1]);
        }
        
        int[] maxes = new int[nums.Length];
        maxes[0]= nums[0];
        maxes[1]=Math.Max(nums[0],nums[1]);
       
        for(int i=2;i<maxes.Length;i++){
            maxes[i]= Math.Max(nums[i]+maxes[i-2],maxes[i-1]);
        }
        
        return maxes[maxes.Length-1];
    }

        
        
}
