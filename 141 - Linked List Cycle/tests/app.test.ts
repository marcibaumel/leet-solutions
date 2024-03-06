import { ListNode, hasCycle } from '../app';

describe('Linked list cycle function tests', () => {
    it('Should return true [3,2,0,-4 => 2]', () => {
        const node1 = new ListNode(3);
        const node2 = new ListNode(2);
        const node3 = new ListNode(0);
        const node4 = new ListNode(-4);

        node1.next = node2;
        node2.next = node3;
        node3.next = node4;
        node4.next = node2;

        expect(hasCycle(node1)).toBe(true);
    });

    it('Should return false [3,2,0,-4 => null]', () => {
        const node1 = new ListNode(3);
        const node2 = new ListNode(2);
        const node3 = new ListNode(0);
        const node4 = new ListNode(-4);

        node1.next = node2;
        node2.next = node3;
        node3.next = node4;
        node4.next = null;

        expect(hasCycle(node1)).toBe(false);
    });
});
