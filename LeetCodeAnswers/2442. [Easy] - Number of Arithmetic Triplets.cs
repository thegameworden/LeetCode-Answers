//This problem can be found at: https://leetcode.com/problems/number-of-arithmetic-triplets

public class Solution {
    public int ArithmeticTriplets(int[] nums, int diff) {
        int counter=0;
        for(int i=0;i<nums.Length-2;i++){
            for(int j=i+1;j<nums.Length-1;j++){
                for(int k = j+1;k<nums.Length;k++){
                    if(nums[j]-nums[i]==diff &&nums[k]-nums[j]==diff)
                    counter++;
                }
            }
        }
    return counter;
    }
    
}
