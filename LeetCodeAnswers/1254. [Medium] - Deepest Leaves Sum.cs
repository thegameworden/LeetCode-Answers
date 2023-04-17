//This problem can be found at: https://leetcode.com/problems/deepest-leaves-sum

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
    public int DeepestLeavesSum(TreeNode root) {
        Queue<TreeNode> q1 = new();
        int deepestSum=-1;
        q1.Enqueue(root);
        while(q1.Count!=0){
            int size = q1.Count;
            deepestSum=0;
            while(size>0){
                TreeNode node = q1.Dequeue();
                deepestSum+=node.val;
            
                if(node.left!=null)
                q1.Enqueue(node.left);
                if(node.right!=null)
                q1.Enqueue(node.right);
                size--;
            }
        }
        return deepestSum;
        
    }
}
