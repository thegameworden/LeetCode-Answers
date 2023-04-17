//This problem can be found at: https://leetcode.com/problems/sort-array-by-parity-ii

public class Solution {
    public int[] SortArrayByParityII(int[] nums) {
        int[] ret = new int[nums.Length];
        
        int even=0;
        int odd=1;
        
        foreach(int num in nums){
        if(num%2==0){
            ret[even]=num;
            even+=2;
        }
            else{
                ret[odd]=num;
                odd+=2;
            }
        }
        
        return ret;
    }
}
