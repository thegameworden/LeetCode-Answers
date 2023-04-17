//This problem can be found at: https://leetcode.com/problems/k-closest-points-to-origin

public class Solution {
    public int[][] KClosest(int[][] points, int k) {
        PriorityQueue<int[], double> distances = new PriorityQueue<int[], double>();
        
        for(int i=0;i<points.Length;i++){
            
            double dist =Math.Sqrt(Math.Pow(-points[i][0],2)+Math.Pow(-points[i][1],2));
            distances.Enqueue(points[i],dist);
        }
        
        int[][] ret = new int[k][];
        for(int i=0;i<ret.Length;i++){
            ret[i]= distances.Dequeue();
        }
        
        return ret;
        
    }
}
