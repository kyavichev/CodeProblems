using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class LinkedListUtils
{
    public static ListNode ToIntListNode(int[] nums)
    {
        if(nums == null)
        {
            return null;
        }

        ListNode first = null;
        ListNode prev = null;
        for(int i = 0; i < nums.Length; i++)
        {
            ListNode newNode = new ListNode();
            newNode.val = nums[i];

            if(first == null)
            {
                first = newNode;
            }
            if(prev != null)
            {
                prev.next = newNode;
            }
            prev = newNode;
        }

        return first;
    }
}
