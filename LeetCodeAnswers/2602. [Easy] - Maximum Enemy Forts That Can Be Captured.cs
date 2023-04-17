//This problem can be found at: https://leetcode.com/problems/maximum-enemy-forts-that-can-be-captured

public class Solution {
    public int CaptureForts(int[] forts) {
        int max =0;
        for(int i=0;i<forts.Length-1;i++){
            for(int j=i+1;j<forts.Length;j++){
                if(forts[i]==forts[j] && forts[i]!=0){
                    i=j;
                }else
                if(Math.Min(forts[i],forts[j])< 0 && Math.Max(forts[i],forts[j])>0){
                    if(max<j-i-1)
                        max=j-i-1;
                    
                    i=j;
                }
                
            }
        }
        
        return max;
    }
}
