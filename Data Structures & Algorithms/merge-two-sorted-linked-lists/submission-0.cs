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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        ListNode head = null;
        if(list1 == null) return list2;
        if(list2== null) return list1;
        if(list1.val < list2.val){
            head = list1;
            list1 = list1.next;
        }else{
            head = list2;
            list2 = list2.next;
        }

        ListNode ptr = head;
        while(list1 !=null && list2!=null){
            if(list1.val < list2.val){
                ptr.next = list1;
                ptr = list1;
                list1 = list1.next;
            }else{
                ptr.next = list2;
                ptr = list2;
                list2 = list2.next;
            }

        }
        if(list1 != null) ptr.next = list1;
        if(list2 != null) ptr.next = list2;
        return head;
         
    }
}