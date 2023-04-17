//This problem can be found at: https://leetcode.com/problems/kth-smallest-element-in-a-bst

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
    public int KthSmallest(TreeNode root, int k) {
        List<TreeNode> nodes = new List<TreeNode>();
        inOrder(root, nodes);
        return nodes[k-1].val;
    }
    private void inOrder(TreeNode node, List<TreeNode> nodes){
        if(node==null)
        return;

        inOrder(node.left,nodes);
        nodes.Add(node);
        inOrder(node.right,nodes);
    }

}
