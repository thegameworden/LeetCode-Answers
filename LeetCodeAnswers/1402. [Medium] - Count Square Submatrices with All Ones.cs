//This problem can be found at: https://leetcode.com/problems/count-square-submatrices-with-all-ones

public class Solution {
    public int CountSquares(int[][] matrix) {
        int size = 1;
        int count=0;
        while(size<=Math.Min(matrix.Length,matrix[0].Length)){

            for(int y=0;y<=matrix.Length-size;y++){
                for(int x=0;x<=matrix[y].Length-size;x++){
                    if(allOnes(matrix,y,x,size))
                        count++;
                    
                }
            }
                
           size++; 
        }
        
        return count;
    }
    
    
    private bool allOnes(int[][] matrix, int y, int x, int size){
        for(int i=y;i<y+size;i++){
            for(int j=x;j<x+size;j++){
                if(matrix[i][j]!=1)
                    return false;
            }
        }
        return true;
    }
}
