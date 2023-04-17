//This problem can be found at: https://leetcode.com/problems/distribute-coins-in-binary-tree

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
    int ans;
    public int DistributeCoins(TreeNode root) {
        ans=0;
        dfs(root);
        return ans;
    }
    
    private int dfs(TreeNode node){
        if(node==null) return 0;
        
        int L = dfs(node.left);
        int R = dfs(node.right);
        
        ans+= Math.Abs(L)+Math.Abs(R);
        return node.val+ L+R-1;
    }
}
