//This problem can be found at: https://leetcode.com/problems/number-of-pairs-of-interchangeable-rectangles

public class Solution {
    public long InterchangeableRectangles(int[][] rectangles) {
        Dictionary<decimal, long> d = new();
        for(int i=0;i<rectangles.Length;i++){
            if(d.ContainsKey((decimal)rectangles[i][0]/(decimal)rectangles[i][1])){
                d[(decimal)rectangles[i][0]/(decimal)rectangles[i][1]]++;
            }else{
                d.Add(((decimal)rectangles[i][0]/(decimal)rectangles[i][1]),1);
            }
        }

        long ret =0;
        foreach(KeyValuePair<decimal,long> kvp in d){
            if(kvp.Value!=1){
                long n=kvp.Value-1;
                ret+= (n*(n+1)/2);
            }
        }
        return ret;

    }
}
/*
2:1
3:3
4:6
5:10
*/
