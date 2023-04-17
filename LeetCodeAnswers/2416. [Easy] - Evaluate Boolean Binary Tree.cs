//This problem can be found at: https://leetcode.com/problems/evaluate-boolean-binary-tree

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
    public bool EvaluateTree(TreeNode root) {
        if (root.left == null && root.right == null) return root.val == 1;
        if(root.val==2) return EvaluateTree(root.left) || EvaluateTree(root.right);
        else return EvaluateTree(root.left) && EvaluateTree(root.right);
    }
}
