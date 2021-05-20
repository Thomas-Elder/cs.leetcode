using Utility;

namespace Problems
{
    /// <summary>
    /// A class for solving Leet Code problem 2. Add Two Numbers
    /// </summary>
    /// You are given two non-empty linked lists representing two non-negative integers. 
    /// The digits are stored in reverse order, and each of their nodes contains a single digit. 
    /// Add the two numbers and return the sum as a linked list.You may assume the two numbers do not contain any leading zero, except the number 0 itself.
    /// 
    /// Input: l1 = [2,4,3], l2 = [5,6,4]
    /// Output: [7,0,8]
    /// Explanation: 342 + 465 = 807.
    /// 
    /// Note:
    /// The number of nodes in each linked list is in the range[1, 100].
    /// 0 <= Node.val <= 9
    /// It is guaranteed that the list represents a number that does not have leading zeros.
    /// 
    public static class AddTwoNumbers
    {

        public static ListNode Add(ListNode l1, ListNode l2)
        {
            int a, b, c, carry;
            carry = 0;

            ListNode node = new ListNode();
            ListNode head = node;

            // While either list is not null, we still have a number to handle
            while (l1 != null || l2 != null)
            { 
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
                if (l1 != null && l1.next != null || l2 != null && l2.next != null)
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
