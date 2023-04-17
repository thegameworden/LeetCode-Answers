//This problem can be found at: https://leetcode.com/problems/merge-two-sorted-lists

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
    public ListNode MergeTwoLists(ListNode l1, ListNode l2) {
        if(l1 == null)
            return l2;
        if(l2 == null)
            return l1;

        var x = l1.next;
        var y = l2.next;

        if(l2.val > l1.val)
        {
            l1.next = MergeTwoLists(x, l2);
            return l1;
        }
        else
        {
            l2.next = MergeTwoLists(y,l1);
            return l2;
        }
    }
}
