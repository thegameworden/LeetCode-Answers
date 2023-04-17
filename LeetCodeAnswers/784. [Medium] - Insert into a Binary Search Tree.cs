//This problem can be found at: https://leetcode.com/problems/insert-into-a-binary-search-tree

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
    public TreeNode InsertIntoBST(TreeNode root, int val) {
    if(root==null){
        root= new TreeNode(val);
        return root;
    }
        BST(root,val);
        return root;
    }
    
    
    private void BST(TreeNode node, int val){
        if(node == null)
            return;
        
        if(node.left == null && node.val > val){
            node.left= new TreeNode(val);
            return;
        }
        
        if(node.right== null && node.val<val){
            node.right = new TreeNode(val);
            return;
        }
        
        if(node.val<val)
            BST(node.right,val);
        
        if(node.val>val)
            BST(node.left,val);

        }
}
