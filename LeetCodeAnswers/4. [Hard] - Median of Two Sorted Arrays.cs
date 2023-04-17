//This problem can be found at: https://leetcode.com/problems/median-of-two-sorted-arrays

public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        double[] final = new double [nums1.Length+nums2.Length];
        
        for(int i=0;i<final.Length;i++){
            if(i<nums1.Length){
                final[i]=nums1[i];
            }else{
                final[i]=nums2[i-nums1.Length];
            }
        }
        
        Array.Sort(final);
        
        double ret;
        
        if(final.Length%2==0){
            ret= final[final.Length/2]+final[final.Length/2-1];
            ret=ret/2;
        }else{
            ret= final[final.Length/2];
        }
            return ret;
        
        
        
        
    }
}
