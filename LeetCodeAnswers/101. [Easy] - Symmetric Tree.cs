//This problem can be found at: https://leetcode.com/problems/symmetric-tree

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
    public bool IsSymmetric(TreeNode root) {
        if(root==null){
            return true;
        }
        
        return symmetric(root.left,root.right);
    }
    
    private bool symmetric(TreeNode node1, TreeNode node2){
         if(node1==null && node2 == null)
            return true;
        
        if((node1==null && node2!=null)|| (node2==null && node1 !=null) || (node1.val !=node2.val))
            return false;
        
       
        
        return symmetric(node1.left,node2.right) && symmetric(node1.right,node2.left);
    }
}
