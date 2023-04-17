//This problem can be found at: https://leetcode.com/problems/reorder-list

public class Solution {
    public void ReorderList(ListNode head) {
        if(head==null || head.next==null)
            return;
        ListNode fast = head, slow = head, prev = null, l1 = head;
        
        while(fast!=null && fast.next!=null)
        {
            prev = slow;
            slow = slow.next;
            fast = fast.next.next;
        }
        
        prev.next = null;
        
        ListNode head2 = Reverse(slow); //This method is defined below.
        ListNode next = null;
        
        while(head2 != null)
        {
            next = head.next;
            head.next = head2;
            
            head = head2;
            head2 = next;
        }
    }
    
    private ListNode Reverse(ListNode head){
        ListNode next = null, prev = null;
        
        while(head!=null){
            next = head.next;
            head.next = prev;
            
            prev = head;
            head = next;
        }
        return prev;
    }
}
