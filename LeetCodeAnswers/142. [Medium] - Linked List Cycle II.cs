//This problem can be found at: https://leetcode.com/problems/linked-list-cycle-ii

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public ListNode DetectCycle(ListNode head) {
        HashSet<ListNode> detector = new HashSet<ListNode>();
        
        while(head!=null){
            if(detector.Contains(head)){
                return head;
            }
            detector.Add(head);
            head=head.next;
        }
        
        return null;
    }
}
