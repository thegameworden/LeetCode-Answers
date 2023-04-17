//This problem can be found at: https://leetcode.com/problems/rotate-image

public class Solution {
    public void Rotate(int[][] matrix) {
       transpose(matrix);
        reflect(matrix);
    }
    
    private void transpose(int[][] matrix){
        int n = matrix.Length;
        for(int i=0;i<n;i++){
            for(int j=i+1;j<n;j++){
                int temp = matrix[j][i];
                matrix[j][i]=matrix[i][j];
                matrix[i][j]=temp;
            }
        }
    }
    
    private void reflect(int[][] matrix){
        int n = matrix.Length;
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < n / 2; j++) {
                int tmp = matrix[i][j];
                matrix[i][j] = matrix[i][n - j - 1];
                matrix[i][n - j - 1] = tmp;
            }
        }
    }
}
