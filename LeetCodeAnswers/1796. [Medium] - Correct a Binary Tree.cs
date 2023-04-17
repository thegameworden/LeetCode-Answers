//This problem can be found at: https://leetcode.com/problems/correct-a-binary-tree

public class Solution {
    
    HashSet<TreeNode> visited = new HashSet<TreeNode>();
    
    public TreeNode CorrectBinaryTree(TreeNode root) {
        
        if(root == null)
            return null;
        
        if(visited.Contains(root.right))
            return null;
        
        visited.Add(root);
        root.right = CorrectBinaryTree(root.right);
        root.left= CorrectBinaryTree(root.left);
        
        return root;
    }
}
