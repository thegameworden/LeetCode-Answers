//This problem can be found at: https://leetcode.com/problems/minimum-number-of-arrows-to-burst-balloons

public class Solution {
    public int FindMinArrowShots(int[][] points) {
     Array.Sort(points,Comparer<int[]>.Create((x,y)=>{
            if (x[1] == y[1]) return 0;
            if (x[1] < y[1]) return -1;
            return 1;})); 
    int arrows=1;
    int xStart, xEnd;
    int firstEnd = points[0][1];
    foreach(int[] p in points){
        xStart= p[0];
        xEnd=p[1];

        if(firstEnd< xStart){
            arrows++;
            firstEnd=xEnd;
        }
    }
     return arrows;  
    }
}

