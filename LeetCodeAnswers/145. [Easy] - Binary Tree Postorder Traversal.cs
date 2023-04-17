//This problem can be found at: https://leetcode.com/problems/binary-tree-postorder-traversal

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
    public IList<int> PostorderTraversal(TreeNode root) {
        ret= new List<int>();
        postorder(root);
        return ret;
    }
    
    private void postorder(TreeNode node){
        if(node==null)
            return;
        
       
        postorder(node.left);
        postorder(node.right);
         ret.Add(node.val);
            
    }
}
