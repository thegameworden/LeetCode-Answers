//This problem can be found at: https://leetcode.com/problems/check-if-n-and-its-double-exist

public class Solution {
    public bool CheckIfExist(int[] arr) {
        for(int i=0;i<arr.Length;i++){
              
            
            if(Array.IndexOf(arr,arr[i]*2) !=-1 && Array.IndexOf(arr,arr[i]*2)!= i){
               
                return true;
            }
        }
        return false;
    }
}
