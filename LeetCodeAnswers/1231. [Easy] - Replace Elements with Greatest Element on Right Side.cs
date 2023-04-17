//This problem can be found at: https://leetcode.com/problems/replace-elements-with-greatest-element-on-right-side

public class Solution {
    public int[] ReplaceElements(int[] arr) {
        for(int i=0;i<arr.Length-1;i++){
            int greatest = arr[i+1];
            for(int j=i+1;j<arr.Length;j++){
                if(arr[j]>greatest){
                    greatest= arr[j];
                }
            }
            arr[i]=greatest;
        }
        arr[arr.Length-1]=-1;
        return arr;
        
    }
}
