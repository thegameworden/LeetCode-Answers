//This problem can be found at: https://leetcode.com/problems/clone-graph

/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;

    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}
*/

public class Solution {
    public Node CloneGraph(Node node) {
        if(node == null){
            return node;
        }
        
        Dictionary<Node,Node> visited = new Dictionary<Node,Node>();
        Queue<Node> queue = new Queue<Node>();
        queue.Enqueue(node);
        
        visited.Add(node, new Node(node.val));
        
        while(queue.Count !=0){
            Node n = queue.Dequeue();
            foreach(Node neighbor in n.neighbors){
                if(!visited.ContainsKey(neighbor)){
                    visited.Add(neighbor, new Node(neighbor.val));
                    queue.Enqueue(neighbor);
                }
                visited[n].neighbors.Add(visited[neighbor]);
            }
        }
        
        
        return visited[node];
    }
}
