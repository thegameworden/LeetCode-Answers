//This problem can be found at: https://leetcode.com/problems/find-leaves-of-binary-tree

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
    List<IList<int>> solution;
    public IList<IList<int>> FindLeaves(TreeNode root) {
        solution= new List<IList<int>>();
        getHeight(root);
        return solution;
    }
    
    private int getHeight(TreeNode root){
        if(root==null)
            return -1;
        
        int leftHeight = getHeight(root.left);
        int rightHeight= getHeight(root.right);
        
        int currHeight = Math.Max(leftHeight,rightHeight)+1;
        
        if(solution.Count == currHeight){
            solution.Add(new List<int>());
        }
                         
        solution[currHeight].Add(root.val);
                         return currHeight;
    }
}
