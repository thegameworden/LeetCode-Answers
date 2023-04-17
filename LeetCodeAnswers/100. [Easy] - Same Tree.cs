//This problem can be found at: https://leetcode.com/problems/same-tree

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
    public bool IsSameTree(TreeNode p, TreeNode q) {
         if(p==null && q==null){
            return true;
        }
        if(p==null && q!= null || q==null && p!= null || p.val != q.val ){
            return false;
        }
       
        return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
    }
}
