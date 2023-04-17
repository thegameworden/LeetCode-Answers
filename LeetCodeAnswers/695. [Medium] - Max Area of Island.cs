//This problem can be found at: https://leetcode.com/problems/max-area-of-island

public class Solution {
    int max;
    public int MaxAreaOfIsland(int[][] grid) {
         max= 0;
        int area=0;
        /*
        Console.WriteLine("-----------Testing----------------------");
        traverseIsland(grid,3,8,0);
        Console.WriteLine("-----------End Testing------------------");
        */
        for(int y=0;y<grid.Length;y++){
            for(int x=0;x<grid[0].Length;x++){
                if(grid[y][x]==1){
                    area=0;
                    traverseIsland(grid,y,x, ref area);
                }
            }
            
        }
        
        
        return max;
    }
    
    private void traverseIsland(int[][] grid, int y, int x, ref int area){
        if(x<0 ||y<0 ||x>=grid[0].Length|| y>=grid.Length|| grid[y][x]==0){
            return;
        }
        
        area++;
       // Console.WriteLine($"Area is {area} from {x},{y}");
        if(area>max){
            
            max=area;
        }
        
        grid[y][x]=0;
        traverseIsland(grid,y+1,x, ref area);
        traverseIsland(grid,y,x+1,ref area);
        traverseIsland(grid,y-1,x,ref area);
        traverseIsland(grid,y,x-1,ref area);
    }
}
