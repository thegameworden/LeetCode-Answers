//This problem can be found at: https://leetcode.com/problems/max-consecutive-ones

public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int counter= 0;
        int temp =0;
        
        for(int i=0;i<nums.Length;i++){
            if(nums[i]==1){
                temp++;
                if(temp>counter){
                    counter=temp;
                }
            }else{
                temp=0;
            }
            
        }
        return counter;
        
    }
}
