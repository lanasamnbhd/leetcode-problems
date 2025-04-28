/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode() { }
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        ListNode curr1 = list1;
        ListNode curr2 = list2;
        ListNode dummyNode = new ListNode(-1);
        ListNode temp = dummyNode;

        while (curr1 != null && curr2 != null) {
            if (curr1.val < curr2.val) {
                temp.next = curr1;
                temp = curr1;
                curr1 = curr1.next;
            } else {
                temp.next = curr2;
                temp = curr2;
                curr2 = curr2.next;
            }
        }

        if (curr1 != null) temp.next = curr1;
        if (curr2 != null) temp.next = curr2;

        return dummyNode.next;
    }
}
