//This problem can be found at: https://leetcode.com/problems/binary-tree-level-order-traversal

/**
 * Definition for a binary tree node.
 * function TreeNode(val, left, right) {
 *     this.val = (val===undefined ? 0 : val)
 *     this.left = (left===undefined ? null : left)
 *     this.right = (right===undefined ? null : right)
 * }
 */
/**
 * @param {TreeNode} root
 * @return {number[][]}
 */
var levelOrder = function(root) {
    // If root is null return an empty array
    if(!root) return []
    
    var queue = [root] // initialize the queue with root
    const levels = [] // declare output array
    
    while(queue.length !== 0){
       const queueLength = queue.length // Get the length prior to dequeueing
       const level = [] // Declare this level
       const next = []
       // loop through to exhaust all options and only to include nodes at currLevel
      while(queue.length!==0){
           // Get next node
           const node = queue.shift()
           
           if(node.left){
               next.push(node.left)
           }
           if(node.right){
               next.push(node.right)
           }
           // After we add left and right for current, we add to currLevel
           level.push(node.val)
       }
       // Level has been finished. Push into output array
       levels.push(level)
       queue= next
   }
    return levels
}
