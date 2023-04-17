//This problem can be found at: https://leetcode.com/problems/maximum-subarray

public class Solution {
    private int[] numsArray;
    public int MaxSubArray(int[] nums) {
        numsArray= nums;
        return findBestSubarray(0,numsArray.Length-1);
    }
    private int findBestSubarray(int left,int right){
        if(left>right){
            return Int32.MinValue;
        }
        int mid = (left+right)/2;
        int curr=0;
        int bestLeftSum = 0;
        int bestRightSum = 0;
        for(int i=mid-1;i>=left;i--){
            curr+=numsArray[i];
              bestLeftSum = Math.Max(bestLeftSum, curr);
        }
        curr = 0;
        for(int i =mid+1;i<=right;i++){
            curr += numsArray[i];
            bestRightSum = Math.Max(bestRightSum, curr);
        }
        
        int bestCombinedSum = numsArray[mid] + bestLeftSum + bestRightSum;
        
         int leftHalf = findBestSubarray(left, mid - 1);
        int rightHalf = findBestSubarray(mid + 1, right);
        
        return Math.Max(bestCombinedSum, Math.Max(leftHalf, rightHalf));
    }
    
}
