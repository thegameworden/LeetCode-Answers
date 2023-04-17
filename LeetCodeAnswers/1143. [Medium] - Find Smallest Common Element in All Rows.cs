//This problem can be found at: https://leetcode.com/problems/find-smallest-common-element-in-all-rows

public class Solution {
    public int SmallestCommonElement(int[][] mat) {
       for(int i=0;i<mat[0].Length;i++){
           if(common(mat,mat[0][i]))
           return mat[0][i];
       }
       return -1;
    }

    private bool common(int[][] mat, int checker){
        for(int y=1;y<mat.Length;y++){
            bool row = false;
            for(int x=0;x<mat[y].Length;x++){
                if(mat[y][x]==checker){
                    row=true;
                    break;
                }


            }
            if(!row)
            return false;
        }
        return true;
    }
}
