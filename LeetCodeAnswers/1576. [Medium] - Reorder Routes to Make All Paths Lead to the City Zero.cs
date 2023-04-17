//This problem can be found at: https://leetcode.com/problems/reorder-routes-to-make-all-paths-lead-to-the-city-zero

public class Solution {
    public int MinReorder(int n, int[][] connections) {
        int res=0;
        
        List<int>[] graph = new List<int>[n];
        
        HashSet<string> sets = new HashSet<string>();
        Queue<int> q = new Queue<int>();
        bool[] visited = new bool[n];
        foreach(var item in connections){
            if(graph[item[0]]==null)
                graph[item[0]]= new List<int>();
            
                
            if(graph[item[1]]==null)
                graph[item[1]]= new List<int>();
            
            
            graph[item[0]].Add(item[1]);
             graph[item[1]].Add(item[0]);
            
            sets.Add(item[0]+"-"+item[1]);
            
        }
        
        q.Enqueue(0);
        visited[0]=true;
        
        while(q.Count>0){
            int cur= q.Dequeue();
            
            foreach(var item in graph[cur]){
                if(!visited[item]){
                    if(!sets.Contains(item+"-"+cur)){
                        res++;
                    }
                    
                    q.Enqueue(item);
                    visited[item]=true;
                }
            }
                
        }
        return res;
    }
}
