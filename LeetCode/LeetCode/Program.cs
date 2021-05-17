using System;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Leet Code Solutions!");

            ListNode l1 = new ListNode(2);
            l1.next = new ListNode(4);
            l1.next.next = new ListNode(3);

            ListNode l2 = new ListNode(5);
            l2.next = new ListNode(6);
            l2.next.next = new ListNode(4);

            ListNode result = Problem_AddTwoNumbers.Add(l1, l2);

            while (result != null)
            {
                Console.Write("{0}", result.val);
                result = result.next;
            }
        }
    }
}
