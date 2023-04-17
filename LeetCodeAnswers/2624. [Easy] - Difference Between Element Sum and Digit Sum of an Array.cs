//This problem can be found at: https://leetcode.com/problems/difference-between-element-sum-and-digit-sum-of-an-array

public class Solution {
    public int DifferenceOfSum(int[] nums) {
        int eSum=0;
        int dSum=0;
        for(int i=0;i<nums.Length;i++){
            int num = nums[i];
            eSum+=num;
            while(num>0){
                dSum+=num%10;
                num/=10;
            }
        }
        
        return Math.Abs(eSum-dSum);
    }
}
