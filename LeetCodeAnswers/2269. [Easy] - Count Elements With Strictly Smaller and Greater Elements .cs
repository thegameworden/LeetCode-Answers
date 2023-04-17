//This problem can be found at: https://leetcode.com/problems/count-elements-with-strictly-smaller-and-greater-elements

public class Solution {
    public int CountElements(int[] nums) {
        int min = nums[0];
        int max= nums[0];

        for(int i=0;i<nums.Length;i++){
            if(min>nums[i])
            min=nums[i];

            if(max<nums[i])
            max=nums[i];
        }

        int counter=0;
        for(int i=0;i<nums.Length;i++){
            if(min<nums[i] && max>nums[i])
            counter++;
        }
        Console.WriteLine($"{min} - {max}");

        return counter;
    }
}
