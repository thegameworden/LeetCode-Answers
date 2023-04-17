//This problem can be found at: https://leetcode.com/problems/form-smallest-number-from-two-digit-arrays

public class Solution {
    public int MinNumber(int[] nums1, int[] nums2) {
        List<int> both = new();
        
        for(int i=0;i<nums1.Length;i++){
            if(nums2.Contains(nums1[i])){
                both.Add(nums1[i]);
            }
        }
        
        if(both.Count!=0){
            int min = 10;
            for(int i=0;i<both.Count;i++){
                if(min>both[i])
                    min=both[i];
                
               
            }
             return min;
        }
        
        int min1=10;
        int min2=10;
        for(int i=0;i<nums1.Length;i++){
            if(min1>nums1[i])
                min1= nums1[i];
        }
        for(int i=0;i<nums2.Length;i++){
            if(min2>nums2[i])
                min2= nums2[i];
        }
        
        int ret=0;
        if(min1<= min2){
            ret = (min1*10)+min2;
        }else{
             ret = (min2*10)+min1;
        }
        return ret;
        
    }
}
