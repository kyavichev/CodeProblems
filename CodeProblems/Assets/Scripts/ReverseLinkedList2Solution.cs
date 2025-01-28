using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public static class ReverseLinkedList2Solution
{
    public static ListNode ReverseBetween(ListNode head, int left, int right)
    {
        if (head.next == null)
        {
            return head;
        }

        // Dummy node in case left is 1 and there are no nodes before
        ListNode tempHead = new ListNode(0, head);

        ListNode leftNode = tempHead;
        for (int i = 0; i < left - 1; i++)
        {
            leftNode = leftNode.next;
        }

        ListNode prev = leftNode;
        ListNode current = prev.next;
        ListNode first = current;

        for (int i = 0; i < right - left + 1; i++)
        {
            if(current == null)
            {
                break;
            }

            ListNode next = current.next;
            current.next = prev;
            prev = current;
            current = next;
        }

        // Link in the front
        leftNode.next = prev;
        // Link to the end
        first.next = current;

        return tempHead.next;
    }
}
