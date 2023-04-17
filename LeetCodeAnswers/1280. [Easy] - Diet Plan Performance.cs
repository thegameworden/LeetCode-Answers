//This problem can be found at: https://leetcode.com/problems/diet-plan-performance

public class Solution {
    public int DietPlanPerformance(int[] calories, int k, int lower, int upper) {
        int score=0;
        for(int i=0;i<=calories.Length-k;i++){
            int temp=0;
            for(int j=i;j<i+k;j++){
                temp+=calories[j];
            }
              
      if(temp<lower){
                score--;
            }
            if(temp>upper){
                score++;
            }
        }

    return score;
    }
    
   
}
