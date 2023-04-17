//This problem can be found at: https://leetcode.com/problems/intersection-of-two-linked-lists

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution
{
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
    {
        HashSet<ListNode> allA = new HashSet<ListNode>();
        while(headA != null)
        {
            allA.Add(headA);

            headA = headA.next;
        }

        while(headB != null)
        {
            if (allA.Contains(headB))
            {

                return headB;
            }
            headB = headB.next;
        }

        return null;

    }
}
