//This problem can be found at: https://leetcode.com/problems/middle-of-the-linked-list

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
    public ListNode MiddleNode(ListNode head) {
        ListNode pointer = head;
        int size=0;
        while(pointer!=null){
            pointer= pointer.next;
            size++;
        }

        for(int i=0;i<size/2;i++){
            head=head.next;
        }
        return head;
    }
}
