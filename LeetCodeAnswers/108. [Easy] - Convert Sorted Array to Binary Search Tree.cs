//This problem can be found at: https://leetcode.com/problems/convert-sorted-array-to-binary-search-tree

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
    public TreeNode SortedArrayToBST(int[] nums) {
        return helper(nums, 0,nums.Length-1);
    }
    
    private TreeNode helper(int[] nums, int left, int right){
        if(left>right) return null;
        
        int p = (left+right)/2;
        
        TreeNode root = new TreeNode(nums[p]);
        root.left = helper(nums,left, p-1);
        root.right =helper(nums,p+1,right);
        
        return root;
    }
}
