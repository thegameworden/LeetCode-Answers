//This problem can be found at: https://leetcode.com/problems/search-a-2d-matrix

public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int m= matrix.Length;
        if(m==0)return false;
        
        int n = matrix[0].Length;
        
        int left=0;
        int right = m*n-1;
        
        while(left<=right){
             int pivotIdx= (left+right)/2;
             int pivotElement= matrix[pivotIdx/n][pivotIdx%n];
            if(target==pivotElement){
                return true;
            }else{
                if(target<pivotElement){
                    right = pivotIdx-1;
                }else{
                    left=pivotIdx+1;
                }
            }
        }
        return false;
    }
}
