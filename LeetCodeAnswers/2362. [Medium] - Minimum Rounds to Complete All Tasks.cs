//This problem can be found at: https://leetcode.com/problems/minimum-rounds-to-complete-all-tasks

public class Solution {
    public int MinimumRounds(int[] tasks) {
        Dictionary<int,int> dtask = new();
        for(int i=0;i<tasks.Length;i++){
            if(dtask.ContainsKey(tasks[i])){
                dtask[tasks[i]]++;
            }else{
                dtask.Add(tasks[i],1);
            }
        }

        int minimum=0;
        foreach(KeyValuePair<int,int> kvp in dtask){
            if(kvp.Value==1)
            return -1;
            if(kvp.Value%3==0){
                minimum+=kvp.Value/3;
            }else{
                minimum+=kvp.Value/3+1;
            }


        }
       
        return minimum;

    }
}
