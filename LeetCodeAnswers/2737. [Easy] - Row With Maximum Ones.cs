//This problem can be found at: https://leetcode.com/problems/row-with-maximum-ones

public class Solution {
    public int[] RowAndMaximumOnes(int[][] mat) {
        int max=0;
        int ret=-1;
        for(int i=mat.Length-1;i>=0;i--){
            int count=0;
            for(int j=0;j<mat[i].Length;j++){
                if(mat[i][j]==1){
                    count++;
                }
            }
            if(max<=count){
                ret=i;
                max=count;
            }
        }
        return new int[]{ret,max};
    }
}
