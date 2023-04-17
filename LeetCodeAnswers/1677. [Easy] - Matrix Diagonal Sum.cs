//This problem can be found at: https://leetcode.com/problems/matrix-diagonal-sum

public class Solution {
    public int DiagonalSum(int[][] mat) {
        int ret = 0;
        for(int i=0;i<mat.Length;i++){
            ret+=mat[i][i]+mat[mat.Length-1-i][i];
        }

        if(mat.Length%2==1)
            ret-=mat[mat.Length/2][mat.Length/2];
        return ret;
    }
}
