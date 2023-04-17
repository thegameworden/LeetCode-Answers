//This problem can be found at: https://leetcode.com/problems/wiggle-sort

public class Solution {
    public void WiggleSort(int[] nums) {
        Array.Sort(nums);
        int[] copy =  new int[nums.Length];
        Array.Copy(nums,copy,nums.Length);
        
        int lowest = 0;
        int highest = copy.Length-1;
        for(int i=0;i<nums.Length;i++){
            if(i%2==0){
                nums[i]=copy[lowest];
                lowest++;
            }else{
                nums[i]=copy[highest];
                highest--;
            }
        }
    }
}
