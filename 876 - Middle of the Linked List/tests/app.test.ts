import { ListNode, middleNode } from '../app';

describe('Middle of the Linked List function test', () => {
    it('Should return the middle part of the Linked list [1,2,3,4,5] => [3, 4, 5]', () => {
        const node1 = new ListNode(1);
        const node2 = new ListNode(2);
        const node3 = new ListNode(3);
        const node4 = new ListNode(4);
        const node5 = new ListNode(5);

        node1.next = node2;
        node2.next = node3;
        node3.next = node4;
        node4.next = node5;

        expect(middleNode(node1)).toBe(node3);
    });

    it('Should return the middle part of the Linked list [1, 2, 3, 4, 5, 6] => [4, 5, 6]', () => {
        const node1 = new ListNode(1);
        const node2 = new ListNode(2);
        const node3 = new ListNode(3);
        const node4 = new ListNode(4);
        const node5 = new ListNode(5);
        const node6 = new ListNode(6);

        node1.next = node2;
        node2.next = node3;
        node3.next = node4;
        node4.next = node5;
        node5.next = node6;

        expect(middleNode(node1)).toBe(node4);
    });

    it('Should return the middle part of the Linked list [1] => [1]', () => {
        const node1 = new ListNode(1);
        
        node1.next = null;
        
        expect(middleNode(node1)).toBe(node1);
    });
});
