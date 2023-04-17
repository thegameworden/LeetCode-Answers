//This problem can be found at: https://leetcode.com/problems/find-all-the-lonely-nodes

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
    TreeNode r;
    public IList<int> GetLonelyNodes(TreeNode root) {
        ret = new List<int>();
        if(root == null)
            return ret;
        r=root;
        dfs(root);
        return ret;
    }
    
    
    private void dfs(TreeNode node){
        if(node ==null)
            return;
        
        if(node.left != null && node.right ==null && node.left != r){
            ret.Add(node.left.val);
        }
        
        if(node.left == null && node.right != null && node.right != r){
            ret.Add(node.right.val);
        }
            dfs(node.left);
            dfs(node.right);
    }
}
