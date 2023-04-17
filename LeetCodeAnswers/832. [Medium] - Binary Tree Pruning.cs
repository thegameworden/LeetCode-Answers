//This problem can be found at: https://leetcode.com/problems/binary-tree-pruning

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
    public TreeNode PruneTree(TreeNode root) {
        
        return Prune(root) ? root :null;

    }

    private bool Prune(TreeNode node){
        if(node==null){
            return false;
        }
        bool left = Prune(node.left);
        bool right = Prune(node.right);
        if(!left) node.left = null;
        if(!right) node.right = null;

        return node.val==1 ||left || right;
        
        
    }
}
