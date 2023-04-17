//This problem can be found at: https://leetcode.com/problems/add-two-numbers

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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        int carry=0;
        ListNode head = l1;
        ListNode previous = l1;
        while(l1!= null && l2!= null){
            l1.val= l1.val+l2.val+ carry;
            carry=0;
            
            if(l1.val>9){
                l1.val-=10;
                carry=1;
            }
            previous=l1;
            l1=l1.next;
            l2=l2.next;
            
            
        }
        
        if(l1==null && l2!=null){
            
            previous.next=l2;
            l1=previous.next;
        }
        
        while(l1!=null){

            l1.val+=carry;

            carry=0;
            if(l1.val>9){
                l1.val-=10;
                carry=1;
            }
            previous=l1;
            l1=l1.next;
        }
        
        if(carry==1){
          previous.next = new ListNode(1);  
        }
        
        
        
        
        
        return head;
        
        
        
        
    }
}
