//This problem can be found at: https://leetcode.com/problems/all-elements-in-two-binary-search-trees

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

    public IList<int> GetAllElements(TreeNode root1, TreeNode root2) {
        ret = new List<int>();
        traverse(root1);
        traverse(root2);
        ret.Sort();
        return ret;
    }


    private void traverse(TreeNode node){
        if(node== null) return;
        traverse(node.left);
        ret.Add(node.val);
        traverse(node.right);
    }
}
