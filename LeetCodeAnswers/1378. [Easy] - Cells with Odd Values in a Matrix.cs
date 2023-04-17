//This problem can be found at: https://leetcode.com/problems/cells-with-odd-values-in-a-matrix

public class Solution {
    int[][] matrix;
    public int OddCells(int m, int n, int[][] indices) {
        matrix = new int[m][];
        for(int i=0;i<m;i++){
            matrix[i]= new int[n];
        }
        //increment(indices);
        //return countOdds();
        for(int i=0;i<indices.Length;i++){   
            int y= indices[i][0];
            int x = indices[i][1];
            for(int j=0;j<matrix.Length;j++){
                matrix[j][x]++;
            }
            for(int j=0;j<matrix[0].Length;j++){
                matrix[y][j]++;
            }
        }
        int counter=0;
        for(int y=0;y<matrix.Length;y++){
            for(int x = 0;x<matrix[y].Length;x++){
               
                if(matrix[y][x]%2==1)counter++;
            }
         
        }
        return counter;

       
    }

    private int countOdds(){
        int counter=0;
        for(int y=0;y<matrix.Length;y++){
            for(int x = 0;x<matrix[y].Length;x++){
               
                if(matrix[y][x]%2==1)counter++;
            }
         
        }
        return counter;
    }

    private void increment(int[][] indices){
        for(int i=0;i<indices.Length;i++){
           
            int y= indices[i][0];
            int x = indices[i][1];
           
            for(int j=0;j<matrix.Length;j++){
                matrix[j][x]++;
            }
            for(int j=0;j<matrix[0].Length;j++){
                matrix[y][j]++;
            }
           
        }
    }

}
