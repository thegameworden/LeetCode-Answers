//This problem can be found at: https://leetcode.com/problems/print-immutable-linked-list-in-reverse

/**
 * // This is the ImmutableListNode's API interface.
 * // You should not implement it, or speculate about its implementation.
 * class ImmutableListNode {
 *     public void PrintValue(); // print the value of this node.
 *     public ImmutableListNode GetNext(); // return the next node.
 * }
 */

public class Solution {
    public void PrintLinkedListInReverse(ImmutableListNode head) {
        if(head.GetNext()!=null)
            PrintLinkedListInReverse(head.GetNext());
        
        head.PrintValue();
        
    }
}
