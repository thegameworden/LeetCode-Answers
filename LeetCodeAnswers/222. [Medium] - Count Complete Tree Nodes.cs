//This problem can be found at: https://leetcode.com/problems/count-complete-tree-nodes

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
    int counter;
    public int CountNodes(TreeNode root) {
        if(root == null){
            return 0;
        }
        
         counter= 0;
        traverse(root);
        
        return counter;
    }
    
    private void traverse(TreeNode node){
        if(node==null){
            return;
        }
        counter++;
       traverse(node.left);
        traverse(node.right);
    }
}
