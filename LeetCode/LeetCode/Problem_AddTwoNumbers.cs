using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public static class Problem_AddTwoNumbers
    {

        public static ListNode Add(ListNode l1, ListNode l2)
        {
            int a, b, c, remainder;
            remainder = 0;

            ListNode node = new ListNode();
            ListNode head = node;

            int i = 1;
            while (l1 != null || l2 != null)
            { 
                Console.WriteLine("{0}", i++);

                a = l1 != null ? l1.val : 0;
                b = l2 != null ? l2.val : 0;
                c = a + b + remainder;
                remainder = 0;

                if (c >= 10)
                {
                    remainder = c / 10;
                    c = c - 10;
                }

                node.val = c;
                node.next = new ListNode();
                node = node.next;

                l1 = l1 != null ? l1.next : null;
                l2 = l2 != null ? l2.next : null;
            }

            if (remainder > 0)
                node.val += remainder;

            if (node.val == 0)
                node = null;

            return head;
        }
    }
}
