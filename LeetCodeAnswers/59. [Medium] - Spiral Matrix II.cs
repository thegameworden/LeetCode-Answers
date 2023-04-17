//This problem can be found at: https://leetcode.com/problems/spiral-matrix-ii

public class Solution {
    public int[][] GenerateMatrix(int n) {
        int[][] result = new int[n][];
        for(int i=0;i<n;i++){
            result[i]= new int[n];
        }
        
        int cnt = 1;
        int[][] dir = {
            new int[]{0,1},
            new int[]{1,0},
            new int[]{0,-1},
            new int[]{-1,0}
        };
        
        int d = 0;
        int x=0;
        int y=0;
        while(cnt<=n*n){
            result[y][x]=cnt;
            cnt++;
            int r= floorMod(y+dir[d][0],n);
            int c= floorMod(x+dir[d][1],n); 
            
            if(result[r][c]!=0)
                d=(d+1)%4;
            y+=dir[d][0];
            x+=dir[d][1];
        }
        return result;
    }
    
    private int floorMod(int x, int y){
        return ((x%y)+y)%y;
    }
}
