//This problem can be found at: https://leetcode.com/problems/longest-continuous-increasing-subsequence

public class Solution {
    int longest;
    public int FindLengthOfLCIS(int[] nums) {
        if(nums.Length==1)
            return 1;
        
        longest=1;
        int temp=1;
        for(int i=1;i<nums.Length;i++){
            if(nums[i-1]<nums[i]){
               temp++;
                if(temp>longest){
                    longest=temp;
                }
            }else{
                
                temp=1;
            }
                
        }
        
        return longest;
    }
}

/*
traverse the array of nums;
start at the second int;

for(){
if(second num is less than previous)
temp++;

else{
check temp with longest;
temp=0
}
}

return longest;




*/
