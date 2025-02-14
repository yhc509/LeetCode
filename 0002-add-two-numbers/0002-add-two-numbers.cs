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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        int x1 = 0;
        int x2 = 0;
        int add = 0;
        ListNode l1_p = l1;
        ListNode l2_p = l2;
        ListNode result = new ListNode();
        ListNode r_p = result;
        while(true) {
            x1 = l1_p != null ? l1_p.val : 0;
            x2 = l2_p != null ? l2_p.val : 0;

            r_p.val = (x1 + x2 + add) % 10;

            Console.WriteLine($"{r_p.val}");

            if(x1 + x2 + add >= 10) add = 1;
            else add = 0;

            if((l1_p == null || l1_p.next == null) && 
               (l2_p == null || l2_p.next == null)) {
                
                if(add > 0) {
                    var last = new ListNode(add);
                    r_p.next = last;
                    r_p = last;
                }
                break;
            }
            Console.WriteLine($"next");
            if(l1_p != null) l1_p = l1_p.next;
            if(l2_p != null) l2_p = l2_p.next;
            var nextResult = new ListNode();
            r_p.next = nextResult;
            r_p = nextResult;
        }
        return result;
    }
}