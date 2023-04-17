//This problem can be found at: https://leetcode.com/problems/duplicate-zeros

public class Solution {
    public void DuplicateZeros(int[] arr) {
        for(int i=0;i<=arr.Length-2;i++){
            
            if(arr[i]==0){
                for(int j=arr.Length-1;j>i;j--){
                    arr[j]=arr[j-1];
                }
                i++;
            }
           
        }
        
    }
}
