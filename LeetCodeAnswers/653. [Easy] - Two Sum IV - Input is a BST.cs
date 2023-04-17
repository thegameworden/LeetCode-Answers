//This problem can be found at: https://leetcode.com/problems/two-sum-iv-input-is-a-bst

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
    int val;
    public bool FindTarget(TreeNode root, int k) {
        pairs= new Dictionary<int,int>();
        val = k;
        return findpairs(root);
    }
    
    private bool findpairs(TreeNode node){
    if(node==null)
        return false;
        
     if(pairs.ContainsKey(node.val))
         return true;
        
        if(!pairs.ContainsKey(val-node.val)){
            pairs.Add(val-node.val,node.val);
        }
        return findpairs(node.left)||findpairs(node.right);
        
    }
}
