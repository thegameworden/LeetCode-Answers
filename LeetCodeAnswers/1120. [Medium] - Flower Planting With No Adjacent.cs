//This problem can be found at: https://leetcode.com/problems/flower-planting-with-no-adjacent

public class Solution {
    public int[] GardenNoAdj(int n, int[][] paths) {
        Dictionary<int,List<int>> garden = new();
        for(int i=0;i<paths.Length;i++){
            if(garden.ContainsKey(paths[i][0])){
                garden[paths[i][0]].Add(paths[i][1]);
            }else{
                garden.Add(paths[i][0], new List<int>{paths[i][1]});
            }
            
            if(garden.ContainsKey(paths[i][1])){
                garden[paths[i][1]].Add(paths[i][0]);
            }else{
                garden.Add(paths[i][1], new List<int>{paths[i][0]});
            }
                
        }
        
           int[] ret = new int[n];
          for (int i = 1; i <= n; i++) {
        // Get the set of used flower types by neighboring gardens
        HashSet<int> used = new HashSet<int>();
        if (garden.ContainsKey(i)) {
            foreach (int j in garden[i]) {
                if (ret[j - 1] > 0) used.Add(ret[j - 1]);
            }
        }
        // Assign the lowest unused flower type to the current garden
        for (int j = 1; j <= 4; j++) {
            if (!used.Contains(j)) {
                ret[i - 1] = j;
                break;
            }
        }
    }

    return ret;
    }
}
