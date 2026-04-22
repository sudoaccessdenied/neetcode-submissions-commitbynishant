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
    public bool HasCycle(ListNode head) {
        if(head == null) return false;
        var slow = head;
        if(slow.next == null) return false;
        var fast = slow.next.next;
        if( fast == null) return false;
        while(slow !=  fast){
            if(slow == null) return false;
            slow = slow.next;
            fast = fast.next;
            if(fast == null) return false;
            fast = fast.next;
            if(fast == null) return false;
        }
        return true;
    }
}
