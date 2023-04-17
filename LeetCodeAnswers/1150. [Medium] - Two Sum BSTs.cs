//This problem can be found at: https://leetcode.com/problems/two-sum-bsts

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
    Dictionary<int,int> pairs;
    int t;
    public bool TwoSumBSTs(TreeNode root1, TreeNode root2, int target) {
        pairs = new Dictionary<int,int>();
        t=target;
        populatePairs(root1);
        return findPair(root2);
    }
    
    private void populatePairs(TreeNode node){
        if(node==null)
            return;
        
        if(!pairs.ContainsKey(t-node.val)){
            pairs.Add(t-node.val,node.val);
        }
        populatePairs(node.left);
        populatePairs(node.right);
    }
    private bool findPair(TreeNode node){
        if(node ==null){
            return false;
        }
        if(pairs.ContainsKey(node.val))
            return true;
        
        return findPair(node.left)|| findPair(node.right);
        
    }
}
