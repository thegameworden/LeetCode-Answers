//This problem can be found at: https://leetcode.com/problems/sort-array-by-parity

public class Solution {
    public int[] SortArrayByParity(int[] nums) {
        int temp;
        int lastEven=0;
        for(int i=0;i<nums.Length;i++){
            if(nums[i]%2==0){
                temp = nums[lastEven];
                nums[lastEven]= nums[i];
                nums[i]=temp;
                lastEven++;
            }
        }
        return nums;
    }
}
