public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null) {
        this.val = val;
        this.next = next;
    }
}

public class Solution {
    public ListNode MergeKLists(List<ListNode> lists) {
        if (lists == null || lists.Count == 0) {
            return null;
        }
        return MergeKListsHelper(lists, 0, lists.Count - 1);
    }

    private ListNode MergeKListsHelper(List<ListNode> lists, int start, int end) {
        if (start == end) {
            return lists[start];
        }
        if (start + 1 == end) {
            return Merge(lists[start], lists[end]);
        }

        int mid = start + (end - start) / 2;
        ListNode left = MergeKListsHelper(lists, start, mid);
        ListNode right = MergeKListsHelper(lists, mid + 1, end);
        return Merge(left, right);
    }

    private ListNode Merge(ListNode l1, ListNode l2) {
        ListNode dummy = new ListNode(0);
        ListNode curr = dummy;

        while (l1 != null && l2 != null) {
            if (l1.val < l2.val) {
                curr.next = l1;
                l1 = l1.next;
            } else {
                curr.next = l2;
                l2 = l2.next;
            }
            curr = curr.next;
        }

        curr.next = (l1 != null) ? l1 : l2;

        return dummy.next;
    }
}
