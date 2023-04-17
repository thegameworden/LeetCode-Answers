//This problem can be found at: https://leetcode.com/problems/increment-submatrices-by-one

public class Solution {
    public int[][] RangeAddQueries(int n, int[][] queries) {
        int[][] mat = new int[n][];
        for(int i=0;i<n;i++){
            mat[i]= new int[n];
        }
        
        for(int i=0;i<queries.Length;i++){
            /*
            int row1= queries[i][0];
            int col1 = queries[i][1];
            int row2 = queries[i][2];
            int col2 = queries[i][3];
            */
            for(int y=queries[i][0];y<=queries[i][2];y++){
                for(int x= queries[i][1];x<=queries[i][3];x++){
                    mat[y][x]++;
                }
            }
            
        }
        
        return mat;
    }
}
