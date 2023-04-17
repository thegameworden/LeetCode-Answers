//This problem can be found at: https://leetcode.com/problems/flood-fill

public class Solution {
    public int[][] FloodFill(int[][] image, int sr, int sc, int newColor) {
        int[][] check = new int[image.Length][];
        for(int i=0;i<image.Length;i++){
            check[i]=new int[image[0].Length];
        }
        floodFill(image, check, sr,sc,newColor,image[sr][sc]);
        return image;
    }
    
    private void floodFill(int[][] image, int[][] check, int y,int x, int newColor, int original){
        if(x<0|| y<0|| x>=image[0].Length|| y>=image.Length||image[y][x]!=original || check[y][x]==1){
            return;
        }
        check[y][x]=1;
        image[y][x]=newColor;
        
        floodFill(image,check, y-1,x,newColor,original);
        floodFill(image,check, y+1,x,newColor,original);
        floodFill(image,check, y,x-1,newColor,original);
        floodFill(image,check, y,x+1,newColor,original);
        
    }
}
