//This problem can be found at: https://leetcode.com/problems/kids-with-the-greatest-number-of-candies

public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        int max= candies[0];
        for(int i=1;i<candies.Length;i++){
            if(candies[i]>max){
                max=candies[i];
            }
        }
        List<bool> ret = new List<bool>();
        for(int i=0;i<candies.Length;i++){
            if(candies[i]+extraCandies>=max){
                ret.Add(true);
            }else{
                ret.Add(false);
            }
        }
        
        return ret;
    }
}
