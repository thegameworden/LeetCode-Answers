//This problem can be found at: https://leetcode.com/problems/rearrange-array-elements-by-sign

public class Solution {
    public int[] RearrangeArray(int[] nums) {
        int[] ret = new int[nums.Length];
        int positive=0;
        int negative = 1;
        
        foreach(int num in nums){
            if(num>0){
                ret[positive]=num;
                positive+=2;
            }else{
                ret[negative]=num;
                negative+=2;
            }
        }
        return ret;
        
    }
}
