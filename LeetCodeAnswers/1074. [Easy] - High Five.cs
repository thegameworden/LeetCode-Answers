//This problem can be found at: https://leetcode.com/problems/high-five

public class Solution {
    public int[][] HighFive(int[][] items) {
        Dictionary<int,List<int>> studentScores = new Dictionary<int,List<int>>();
        for(int i=0;i<items.Length;i++){
            if(studentScores.ContainsKey(items[i][0])){
                studentScores[items[i][0]].Add(items[i][1]);
            }else{
                studentScores.Add(items[i][0], new List<int>{items[i][1]});
            }
        }

        List<int[]> average = new List<int[]>();
        int pointer=0;
        foreach(KeyValuePair<int, List<int>> kvp in studentScores){
          
            int[] adder= new int[2];
            adder[0]=kvp.Key;
            kvp.Value.Sort((a, b) => b.CompareTo(a));
            int scores=0;

            int divisor= Math.Min(5, kvp.Value.Count);
            for(int i=0;i<divisor;i++){
                scores+=kvp.Value[i];
            }

           adder[1]=scores/divisor;
           average.Add(adder);
        }
        average.Sort((a,b)=> a[0].CompareTo(b[0]));
        return average.ToArray();
    }
}
