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
    public ListNode MergeKLists(ListNode[] lists) {
        if(lists.Length ==0){
            return null;
        }
        ListNode merged = lists[0];
        for(int i = 1;i<lists.Length;i++){
             merged = MergeList(merged,lists[i]);
        }
        return merged;
        
    }

    public ListNode MergeList(ListNode first, ListNode second){
            if(first == null) return second;
            if(second == null) return first;
            ListNode merged = null;
            ListNode ptr = merged;
            while(first != null && second != null){
                ListNode temp = null;
                if(first.val < second.val){
                    temp = first;
                    first = first.next;
                }else {
                    temp = second;
                    second = second.next;
                }
                if(merged == null){
                    merged = temp;
                    ptr = merged;
                }else{
                    ptr.next = temp;
                    ptr = temp;
                }
            }
            if(first != null){
                ptr.next = first;
            }
            if(second != null){
                ptr.next = second;
            }
            return merged;
    }
}
