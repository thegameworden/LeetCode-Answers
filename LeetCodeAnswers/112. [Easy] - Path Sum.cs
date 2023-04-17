//This problem can be found at: https://leetcode.com/problems/path-sum

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
    public bool HasPathSum(TreeNode root, int targetSum) {
        if(root == null){
            return false;
        }
        
        return dfs(root, 0, targetSum);
    }
    
    private bool dfs(TreeNode node, int total, int targetSum){
        if(node.left ==null && node.right == null ){
            total+=node.val;
            if(total == targetSum){
                return true;
            }
            
            return false;
        }
        
        
        total+=node.val;
        
        if(node.left!=null && node.right==null){
            
            return dfs(node.left,total,targetSum);
        }else if(node.right!=null && node.left==null){
            return dfs(node.right,total,targetSum);
        }
        
          
        
        return  dfs(node.right,total,targetSum)||dfs(node.left,total,targetSum);
    }
}
