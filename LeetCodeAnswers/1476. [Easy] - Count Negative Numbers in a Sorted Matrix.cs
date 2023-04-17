//This problem can be found at: https://leetcode.com/problems/count-negative-numbers-in-a-sorted-matrix

public class Solution {
    public int CountNegatives(int[][] grid) {
        int neg =0;
        for(int i=0;i<grid.Length;i++){
            for(int j=0;j<grid[i].Length;j++){
                if(grid[i][j]<0)
                neg++;
            }
        }
        return neg;
    }
}
