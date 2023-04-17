//This problem can be found at: https://leetcode.com/problems/queries-on-number-of-points-inside-a-circle

public class Solution {
    public int[] CountPoints(int[][] points, int[][] queries) {
        int[] ret = new int[queries.Length];

        for(int i=0;i<ret.Length;i++){
            foreach(int[] point in points){
                if(InCircle(point,queries[i])){
                    ret[i]++;
                }
            }

        }
        return ret;
    }


    private bool InCircle(int[] point, int[] circle){
    /*    int x = point[0];
        int y = point[1];
        int cx = circle[0];
        int cy = circle[1];
        double rad = (double)circle[2];
        double distance = Math.Sqrt(Math.Pow(x-cx,2)+Math.Pow(y-cy,2));
        return distance <=circle[2];

*/
        return Math.Sqrt(Math.Pow(point[0]-circle[0],2)+Math.Pow(point[1]-circle[1],2)) <=circle[2];
    }
}
