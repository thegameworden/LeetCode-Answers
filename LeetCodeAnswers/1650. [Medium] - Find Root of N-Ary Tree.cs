//This problem can be found at: https://leetcode.com/problems/find-root-of-n-ary-tree

/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> children;
    
    public Node() {
        val = 0;
        children = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        children = new List<Node>();
    }
    
    public Node(int _val, List<Node> _children) {
        val = _val;
        children = _children;
    }
}
*/

public class Solution {
    public Node FindRoot(List<Node> tree) {
        List<Node> children = new List<Node>();
        foreach(Node node in tree){
            foreach(Node child in node.children){
                children.Add(child);
            }
        }
        
        for(int i=0;i<tree.Count;i++){
            if(!children.Contains(tree[i])){
                return tree[i];
            }
        }
        
        return null;
    }
}

/*
List<Node> children;

foreach node in tree, add its children to the children list

foreach node in tree, if it isnt in children list, it is root, so return it.
*/
