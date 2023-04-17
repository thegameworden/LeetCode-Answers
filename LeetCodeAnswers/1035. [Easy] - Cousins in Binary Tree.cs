//This problem can be found at: https://leetcode.com/problems/cousins-in-binary-tree

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
    int xDepth;
    int yDepth;
    TreeNode xParent;
    TreeNode yParent;
    int xVal;
    int yVal;
    public bool IsCousins(TreeNode root, int x, int y) {
        xDepth=0;
        yDepth=0;
        xParent = null;
        yParent = null;
        xVal=x;
        yVal=y;
        traverse(root, 0);
        return xParent!=yParent && xDepth == yDepth; 
    }

    private void traverse(TreeNode node, int depth){
        if(node==null) return;

        if((node.left!=null && node.left.val == xVal) || (node.right!=null && node.right.val == xVal)){
            xDepth= depth+1;
            xParent = node;
        }

        if((node.left!=null && node.left.val == yVal) || (node.right!=null && node.right.val == yVal)){
            yDepth= depth+1;
            yParent = node;
        }       
        depth++;
        traverse(node.left,depth);
        traverse(node.right, depth);

    }
}
