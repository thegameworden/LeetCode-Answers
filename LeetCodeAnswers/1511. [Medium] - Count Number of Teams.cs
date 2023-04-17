//This problem can be found at: https://leetcode.com/problems/count-number-of-teams

public class Solution {
    public int NumTeams(int[] rating) {
        int count=0;
        for(int i=0;i<rating.Length-2;i++){
            for(int j=i+1;j<rating.Length-1;j++){
                for(int k=j+1;k<rating.Length;k++){
                    if((rating[i]<rating[j] && rating[j]<rating[k]) || (rating[i]>rating[j] && rating[j]>rating[k]))
                        count++;
                }
            }
        }
        return count;
    }
}
