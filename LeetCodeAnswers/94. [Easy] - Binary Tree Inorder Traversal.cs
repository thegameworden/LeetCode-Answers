//This problem can be found at: https://leetcode.com/problems/binary-tree-inorder-traversal

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
    public IList<int> InorderTraversal(TreeNode root) {
        ret = new List<int>();
        
        inorderTrav(root);
        return ret;
    }
    
    private void inorderTrav(TreeNode node){
        if(node == null)
            return;
        
        inorderTrav(node.left);
        ret.Add(node.val);
        inorderTrav(node.right);
    }
}
