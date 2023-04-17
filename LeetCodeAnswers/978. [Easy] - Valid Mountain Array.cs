//This problem can be found at: https://leetcode.com/problems/valid-mountain-array

public class Solution {
    public bool ValidMountainArray(int[] arr) {
     if(arr.Length<3)
         return false;
        bool peak= false;
    
     for(int i=0;i<arr.Length-1;i++){
        
      if((arr[i]==arr[i+1]) ||(arr[i]>arr[i+1] && i==0))
          return false;
         
         if(arr[i]>arr[i+1]){
         
             peak=true;
         }
         
         if(arr[i]<arr[i+1] && peak==true)
             return false;
             
     }
        
        if(!peak)
            return false;
        return true;
    }
}
