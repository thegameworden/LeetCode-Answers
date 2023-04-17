//This problem can be found at: https://leetcode.com/problems/shortest-distance-to-target-color

public class Solution {
    List<int> ret;
    public IList<int> ShortestDistanceColor(int[] colors, int[][] queries) {
        ret= new List<int>();
        
        finder(colors,queries[0][0], queries[0][1]);
        if(queries.Length>1){
        for(int i=1;i<queries.Length;i++){
            if(queries[i][0]==queries[i-1][0] && queries[i][1]==queries[i-1][1]){
                ret.Add(ret[i-1]);
                continue;            
            }
                
            finder(colors, queries[i][0], queries[i][1]);
        }
    }
        return ret;
    }
    
    private void finder(int[] colors, int start, int targetColor){
        if(Array.FindIndex(colors, color=> color==targetColor)<0){
            ret.Add(-1);
            return;
        }
        
        if(colors[start]==targetColor){
            ret.Add(0);
            return;
        }
        
        int goLeft=0;
        int goRight=0;
        int foundLeft=-1;
        int foundRight=-1;
        for(int i=start;i<colors.Length;i++){
            if(colors[i]==targetColor){
                foundRight=goRight;
                break;
            }else{
                goRight++;
            }
        }
        
        for(int i=start;i>=0;i--){
            if(colors[i]==targetColor){
                foundLeft=goLeft;
                break;
            }else{
                goLeft++;
            }
        }
        
        
        if(foundLeft !=-1 && foundRight !=-1){
            ret.Add(Math.Min(foundLeft,foundRight));
        
        }else if(foundLeft!=-1){
            ret.Add(foundLeft);
        }else{
            ret.Add(foundRight);
        }                
        
        
        
    }
}
