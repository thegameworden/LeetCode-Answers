//This problem can be found at: https://leetcode.com/problems/binary-tree-level-order-traversal

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
    public IList<IList<int>> LevelOrder(TreeNode root) {
        List<IList<int>> ret = new List<IList<int>>();
        if(root==null)
            return ret;
        Queue<TreeNode> lot = new Queue<TreeNode>();
        lot.Enqueue(root);
        while(lot.Count!=0){
            Queue<TreeNode> temp = new Queue<TreeNode>();
            List<int> adder = new List<int>();
            while(lot.Count!=0){
                TreeNode tempNode= lot.Dequeue();
                adder.Add(tempNode.val);
                if(tempNode.left!=null){
                    temp.Enqueue(tempNode.left);
                }
                if(tempNode.right!=null){
                    temp.Enqueue(tempNode.right);
                }
            }
            ret.Add(adder);
            lot= temp;
            
        }
        return ret;
    }
}
