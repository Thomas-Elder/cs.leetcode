using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public static class Problem_AddTwoNumbers
    {

        public static ListNode Add(ListNode l1, ListNode l2)
        {
            int a, b, c, carry;
            carry = 0;

            ListNode node = new ListNode();
            ListNode head = node;

            int i = 1;

            // While either list is not null, we still a number to handle
            while (l1 != null || l2 != null)
            { 
                Console.WriteLine("{0}", i++);

                // Get the value of this node, or use zero if it's null
                a = l1 != null ? l1.val : 0;
                b = l2 != null ? l2.val : 0;

                // Calculate the sum, including carries from the previous sum
                c = a + b + carry;

                // Reset the carry
                carry = 0;

                // If c is 10+, we need to carry 1 forward to the next node, and set c - 10
                if (c >= 10)
                {
                    carry = c / 10;
                    c = c - 10;
                }

                // Assign c to this node
                node.val = c;

                // If there's another node in either list, we'll need another result node
                if (l1.next != null || l2.next != null)
                {
                    node.next = new ListNode();
                    node = node.next;
                }

                // Set each list to the next node
                l1 = l1 != null ? l1.next : null;
                l2 = l2 != null ? l2.next : null;
            }

            // Add any significant carry over to the tail
            if (carry > 0)
            {
                node.next = new ListNode();
                node.next.val = carry;
            }

            return head;
        }
    }
}
