//This problem can be found at: https://leetcode.com/problems/find-center-of-star-graph

public class Solution {
    public int FindCenter(int[][] edges) {
        int n = edges.Length;
       Dictionary<int,int> graph = new();
       for(int i=0;i<edges.Length;i++){
           int edgeA = edges[i][0];
           int edgeB = edges[i][1];
           if(!graph.ContainsKey(edgeA)){
               graph.Add(edgeA,1);
           }else{
               graph[edgeA]++;
               if(graph[edgeA]== n)
               return edgeA;
           }
            
            if(!graph.ContainsKey(edgeB)){
               graph.Add(edgeB,1);
           }else{
               graph[edgeB]++;
               if(graph[edgeB]== n)
               return edgeB;
           }


       }

        return -1; 
    }
}

/*

1- 2 5 3 4
*/
