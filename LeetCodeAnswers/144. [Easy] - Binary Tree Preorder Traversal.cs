//This problem can be found at: https://leetcode.com/problems/binary-tree-preorder-traversal

/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    List<int> ret;
    public IList<int> PreorderTraversal(TreeNode root) {
        ret= new List<int>();
        preorder(root);
        return ret;
    }
    
    private void preorder(TreeNode node){
        if(node==null)
            return;
        
        ret.Add(node.val);
        preorder(node.left);
        preorder(node.right);
            
    }
}
