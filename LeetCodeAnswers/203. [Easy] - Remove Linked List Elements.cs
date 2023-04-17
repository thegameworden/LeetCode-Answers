//This problem can be found at: https://leetcode.com/problems/remove-linked-list-elements

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
    public ListNode RemoveElements(ListNode head, int val){
          if(head==null){
            return head;
        }
        while(head.val==val&& head.next !=null){
            head=head.next;
        }
        if(head.val ==val){
            return null;
        }
        
        ListNode pointer = head;
        ListNode prev= head;
        
        
        while(pointer!=null){
           if(pointer.val==val){
               prev.next=pointer.next;
               pointer=pointer.next;
               continue;
           }
            prev=pointer;
            pointer=pointer.next;
            
            
        }    
        return head;
    
}}
