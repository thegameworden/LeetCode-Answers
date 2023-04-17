//This problem can be found at: https://leetcode.com/problems/sum-of-all-odd-length-subarrays

public class Solution {
    public int SumOddLengthSubarrays(int[] arr) {
        int odd=1;
        int sum =0;
        while(odd<=arr.Length){
            for(int i=0;i<=arr.Length-odd;i++){
            for(int j=i;j<i+odd;j++){
                sum+=arr[j];
            }
            }


            odd+=2;
        }
        return sum;
    }
}
