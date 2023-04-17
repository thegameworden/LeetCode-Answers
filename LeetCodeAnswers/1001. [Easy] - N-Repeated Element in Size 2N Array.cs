//This problem can be found at: https://leetcode.com/problems/n-repeated-element-in-size-2n-array

public class Solution {
    public int RepeatedNTimes(int[] nums) {
        int n = nums.Length/2;
        Dictionary<int,int> d = new();
        for(int i=0;i<nums.Length;i++){
            if(d.ContainsKey(nums[i])){
                d[nums[i]]++;
                if(d[nums[i]]==n)return nums[i];
            }else{
                d.Add(nums[i],1);
            }
        }
        return -1;
    }
}
