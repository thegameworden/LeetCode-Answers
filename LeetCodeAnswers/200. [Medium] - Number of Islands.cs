//This problem can be found at: https://leetcode.com/problems/number-of-islands

public class Solution {
    public int NumIslands(char[][] grid) {
        int counter=0;
        for(int y=0;y<grid.Length;y++){
            for(int x=0;x<grid[0].Length;x++){
                if(grid[y][x]=='1'){
                    counter++;
                    traverseIsland(grid,y,x);
                }
            }
        }
        return counter;
    }
    
    
    private void traverseIsland(char[][] grid, int y, int x){

        
        if(y<0||x<0|| y>=grid.Length|| x>= grid[0].Length || grid[y][x] =='0')
            return;
        
        grid[y][x]='0';
        traverseIsland(grid,y+1,x);
         traverseIsland(grid,y-1,x);
         traverseIsland(grid,y,x+1);
         traverseIsland(grid,y,x-1);
    }
}
