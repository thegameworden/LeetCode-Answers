//This problem can be found at: https://leetcode.com/problems/longest-line-of-consecutive-one-in-matrix

public class Solution {
    int longest;
    public int LongestLine(int[][] mat) {
         longest = 0;
        int counter = 0;
        for(int y=0;y<mat.Length;y++){
            for(int x=0;x<mat[0].Length;x++){
                if(mat[y][x]==1){
                    traverse(mat, counter, x,y);
                }
            }
        }
        
        return longest;
        
    }
    
    private void traverse(int[][] mat, int counter, int x, int y){
        goHorizontal(mat,counter,x,y);
        goVertical(mat,counter,x,y);
        goDiagonal(mat,counter,x,y);
        goAnti(mat,counter,x,y);
    }
    
    private void goHorizontal(int[][] mat, int counter, int x, int y){
        if(y<0 || x<0 || y>=mat.Length|| x>=mat[0].Length|| mat[y][x]==0 ){
            return;
        }
        
        counter++;
        
        if(counter>longest){
            longest = counter;
        }
        
        goHorizontal(mat,counter,x+1,y);
    }
    
        private void goVertical(int[][] mat, int counter, int x, int y){
        if(y<0 || x<0 || y>=mat.Length || x>=mat[0].Length|| mat[y][x]==0 ){
            return;
        }
        
        counter++;
        if(counter>longest){
            longest = counter;
        }
        
        goVertical(mat,counter,x,y+1);
    }
    
            private void goDiagonal(int[][] mat, int counter, int x, int y){
        if(y<0 || x<0 || y>=mat.Length || x>=mat[0].Length|| mat[y][x]==0 ){
            return;
        }
        
        counter++;
        if(counter>longest){
            longest = counter;
        }
        
        goDiagonal(mat,counter,x+1,y+1);
    }
    
             private void goAnti(int[][] mat, int counter, int x, int y){
        if(y<0 || x<0 || y>=mat.Length || x>=mat[0].Length|| mat[y][x]==0 ){
            return;
        }
        
        counter++;
        if(counter>longest){
            longest = counter;
        }
        
        goAnti(mat,counter,x+1,y-1);
    }
    
    
    
    
}
