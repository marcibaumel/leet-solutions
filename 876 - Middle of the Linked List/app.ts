export class ListNode {
    val: number;
    next: ListNode | null;
    constructor(val?: number, next?: ListNode | null) {
        this.val = val === undefined ? 0 : val;
        this.next = next === undefined ? null : next;
    }
}

export function middleNode(head: ListNode | null): ListNode | null {
    if (!head) {
        return null;
    }

    let slow: ListNode = head;
    let fast: ListNode = head;

    while (fast && fast.next) {
        slow = slow.next;
        fast = fast.next.next;
    }

    return slow;
}
