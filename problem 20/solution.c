#include <stdio.h>
#include <stdlib.h>

typedef struct ListNode {
    int val;
    struct ListNode* next;
} ListNode;

ListNode* merge(ListNode* l1, ListNode* l2) {
    ListNode dummy = {0, NULL};
    ListNode* curr = &dummy;

    while (l1 && l2) {
        if (l1->val < l2->val) {
            curr->next = l1;
            l1 = l1->next;
        } else {
            curr->next = l2;
            l2 = l2->next;
        }
        curr = curr->next;
    }

    curr->next = l1 ? l1 : l2;
    return dummy.next;
}

ListNode* mergeKListsHelper(ListNode** lists, int start, int end) {
    if (start == end) {
        return lists[start];
    }
    if (start + 1 == end) {
        return merge(lists[start], lists[end]);
    }

    int mid = start + (end - start) / 2;
    ListNode* left = mergeKListsHelper(lists, start, mid);
    ListNode* right = mergeKListsHelper(lists, mid + 1, end);
    return merge(left, right);
}

ListNode* mergeKLists(ListNode** lists, int listsSize) {
    if (listsSize == 0) return NULL;
    return mergeKListsHelper(lists, 0, listsSize - 1);
}
