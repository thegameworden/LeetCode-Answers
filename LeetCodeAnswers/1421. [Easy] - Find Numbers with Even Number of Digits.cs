//This problem can be found at: https://leetcode.com/problems/find-numbers-with-even-number-of-digits

public class Solution {
    public int FindNumbers(int[] nums) {
        int evenNumberD=0;
        for(int i=0;i<nums.Length;i++){
            if(evenCount(nums[i]))
            evenNumberD++;
        }

        return evenNumberD;
    }

    private bool evenCount(int num){
        int count=0;
        while(num>0){
            count++;
            num/=10;
        }
        return count%2==0;
    }
}
