//This problem can be found at: https://leetcode.com/problems/find-if-path-exists-in-graph

public class Solution {
    public bool ValidPath(int n, int[][] edges, int source, int destination) {
        if(edges.Length==0){
            return true;
        }
        bool[] visited = new bool[n];
        Dictionary<int,List<int>> graph = createGraph(edges);      
        return traverse(graph, source,visited,destination);

    }

    public bool traverse( Dictionary<int,List<int>> graph, int source,  bool[] visited, int destination){
        if(source==destination)
        return true;

        if(!visited[source]){
        visited[source]=true;
        for(int i=0;i<graph[source].Count;i++)
        {
           if(traverse(graph,graph[source][i],visited,destination))
           return true;
        }
        }
         return false;
    
    }

    private Dictionary<int,List<int>> createGraph(int[][] edges){
        Dictionary<int,List<int>> graph = new Dictionary<int,List<int>>();
          for(int i=0;i<edges.Length;i++){
            if(graph.ContainsKey(edges[i][0])){
                graph[edges[i][0]].Add(edges[i][1]);
            }else{
                graph.Add(edges[i][0],new List<int>{edges[i][1]});
            }

            if(graph.ContainsKey(edges[i][1])){
                graph[edges[i][1]].Add(edges[i][0]);
            }else{
                graph.Add(edges[i][1],new List<int>{edges[i][0]});
            }
        }
        return graph;
    }
}
