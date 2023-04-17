//This problem can be found at: https://leetcode.com/problems/container-with-most-water

public class Solution {
    public int MaxArea(int[] height) {
        int max = 0;
        
        
        for(int i =0;i<height.Length-1;i++){
            for(int j=i+1;j<height.Length;j++){
                max= Math.Max(max,Math.Min(height[i],height[j])* (j-i));
            }
        }
        return max;
    }
}
