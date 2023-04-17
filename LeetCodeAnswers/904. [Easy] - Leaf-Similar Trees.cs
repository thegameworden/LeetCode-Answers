//This problem can be found at: https://leetcode.com/problems/leaf-similar-trees

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
    List<int> tree1;
    List<int> tree2;
    public bool LeafSimilar(TreeNode root1, TreeNode root2) {
        tree1 =new();
        tree2= new();
        traverse(root1,tree1);
        traverse(root2,tree2);

        if(tree1.Count!=tree2.Count) return false;

        for(int i=0;i<tree1.Count;i++){
            if(tree1[i]!= tree2[i]) return false;
        }
        return true;
    }

    private void traverse(TreeNode node, List<int> tree){
        if(node==null) return;

        if(node.left== null && node.right == null)
            tree.Add(node.val);

        traverse(node.left,tree);
        traverse(node.right,tree);
    }
}
