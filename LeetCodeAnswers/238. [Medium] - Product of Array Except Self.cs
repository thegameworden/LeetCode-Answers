//This problem can be found at: https://leetcode.com/problems/product-of-array-except-self

public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] answer = new int[nums.Length];
        answer[0]=1;
        for(int i=1;i<nums.Length;i++){
            answer[i]=nums[i-1]*answer[i-1];
        }
        int r=1;
        for(int i=nums.Length-1;i>=0;i--){
            answer[i]=answer[i]*r;
            r*=nums[i];
        }
        
        return answer;
    }
}
