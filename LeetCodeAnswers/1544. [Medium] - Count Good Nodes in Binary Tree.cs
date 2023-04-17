//This problem can be found at: https://leetcode.com/problems/count-good-nodes-in-binary-tree

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
    int count;
    public int GoodNodes(TreeNode root) {
       if(root==null) return 0;
       count=0;

       traverse(root,root.val);
       return count;
    }
    private void traverse(TreeNode node, int max){
        if(node==null) return;
        if(max<= node.val){
            count++;
            max = node.val;
        }

        traverse(node.left,max);
        traverse(node.right,max);
    }
}
