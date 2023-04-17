//This problem can be found at: https://leetcode.com/problems/delete-nodes-and-return-forest

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
    List<TreeNode> ret;
    public IList<TreeNode> DelNodes(TreeNode root, int[] to_delete) {
        ret= new List<TreeNode>();
        if(root==null)
            return ret;
      
        if(Array.IndexOf(to_delete,root.val)>=0){
            if(root.left!=null)
                ret.Add(root.left);
            
            if(root.right!=null)
                ret.Add(root.right);
        }
        
        
        ret.Add(root);
        dfsDelete(root, to_delete);
        return ret;
        
    }
    
    
    private void dfsDelete(TreeNode node, int[] to_delete){
        
        if(node==null)
            return;
        
        if(Array.IndexOf(to_delete,node.val)>=0){
            ret.Remove(node);
        }
           
          
        if(node.left!=null){
            dfsDelete(node.left, to_delete);
            if(Array.IndexOf(to_delete,node.left.val)>=0){
                //add node.left's children
                if(node.left.left !=null){
                    ret.Add(node.left.left);
                }
                if(node.left.right !=null){
                    ret.Add(node.left.right);
                }
                node.left= null;
            }
            
           
        }
        
        
        if(node.right!=null){
            dfsDelete(node.right, to_delete);
            if(Array.IndexOf(to_delete,node.right.val)>=0){
                //add node.right's children
                if(node.right.left !=null){
                    ret.Add(node.right.left);
                }
                if(node.right.right !=null){
                    ret.Add(node.right.right);
                }
                node.right= null;
            }
            
            
        }
        
        
        
    }
    
    
}

/*
        1
        /\
        2 {null}
        /\
       4 3

if(parent points to any of to_delete){
add to_delete's children to ret;
parent points to null;
}

call method for each child;



EDGE:
what if we delete root;


*/
