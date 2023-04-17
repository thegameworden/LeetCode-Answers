//This problem can be found at: https://leetcode.com/problems/shuffle-the-array

public class Solution {
    public int[] Shuffle(int[] nums, int n) {
    int[] ret = new int[nums.Length];
        
        int pointerX=0;
        int pointerY=n;
        int position=0;
        while(position<nums.Length){
            if(position %2== 1){
                ret[position]=nums[pointerY];
                pointerY++;
            }else{
                ret[position]=nums[pointerX];
                pointerX++;
                
            }
            position++;
        }
        
        return ret;
    }
}
