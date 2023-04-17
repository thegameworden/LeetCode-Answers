//This problem can be found at: https://leetcode.com/problems/check-if-matrix-is-x-matrix

public class Solution {
    public bool CheckXMatrix(int[][] grid) {
        for(int y=0;y<grid.Length;y++){
            for(int x=0;x<grid.Length;x++){
               // Console.WriteLine($"{y},{x} = {grid[y][x]}");
                if(y==x || y==grid.Length-x-1){
                    
                    if(grid[y][x]==0)
                    return false;
                }else{
                    if(grid[y][x]!=0)
                    return false;
                }
            }
        }
        return true;
    }
}
