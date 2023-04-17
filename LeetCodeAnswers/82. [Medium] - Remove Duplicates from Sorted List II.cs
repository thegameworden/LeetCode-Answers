//This problem can be found at: https://leetcode.com/problems/remove-duplicates-from-sorted-list-ii

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode DeleteDuplicates(ListNode head) {
       
        ListNode sent= new ListNode(0,head);
         ListNode prev = sent;
        
        while(head!=null){
            
            if(head.next!=null && head.val==head.next.val){
                while(head.next!=null && head.val==head.next.val){
                    head=head.next;
                }
                prev.next=head.next;
            }
            
            else{
                prev=prev.next;
            }
          head=head.next;
            
        }
        
        
        return sent.next;
    }
}
